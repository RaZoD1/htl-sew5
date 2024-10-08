using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using _02_Messwerte.Data;
using _02_Messwerte.Model;

namespace _02_Messwerte.Pages.MessStationen
{
    public class DeleteModel : PageModel
    {
        private readonly _02_Messwerte.Data.MessDataContext _context;

        public DeleteModel(_02_Messwerte.Data.MessDataContext context)
        {
            _context = context;
        }

        [BindProperty]
        public MessStation MessStation { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var messstation = await _context.MessStationen.FirstOrDefaultAsync(m => m.Id == id);

            if (messstation == null)
            {
                return NotFound();
            }
            else
            {
                MessStation = messstation;
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var messstation = await _context.MessStationen.FindAsync(id);
            if (messstation != null)
            {
                MessStation = messstation;
                _context.MessStationen.Remove(MessStation);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
