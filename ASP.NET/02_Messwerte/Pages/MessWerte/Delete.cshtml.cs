using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using _02_Messwerte.Data;
using _02_Messwerte.Model;

namespace _02_Messwerte.Pages.MessWerte
{
    public class DeleteModel : PageModel
    {
        private readonly _02_Messwerte.Data.MessDataContext _context;

        public DeleteModel(_02_Messwerte.Data.MessDataContext context)
        {
            _context = context;
        }

        [BindProperty]
        public MessWert MessWert { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var messwert = await _context.MessWert.FirstOrDefaultAsync(m => m.Id == id);

            if (messwert == null)
            {
                return NotFound();
            }
            else
            {
                MessWert = messwert;
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var messwert = await _context.MessWert.FindAsync(id);
            if (messwert != null)
            {
                MessWert = messwert;
                _context.MessWert.Remove(MessWert);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
