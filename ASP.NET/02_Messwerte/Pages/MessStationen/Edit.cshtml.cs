using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using _02_Messwerte.Data;
using _02_Messwerte.Model;

namespace _02_Messwerte.Pages.MessStationen
{
    public class EditModel : PageModel
    {
        private readonly _02_Messwerte.Data.MessDataContext _context;

        public EditModel(_02_Messwerte.Data.MessDataContext context)
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

            var messstation =  await _context.MessStationen.FirstOrDefaultAsync(m => m.Id == id);
            if (messstation == null)
            {
                return NotFound();
            }
            MessStation = messstation;
            return Page();
        }

        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more information, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(MessStation).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!MessStationExists(MessStation.Id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool MessStationExists(int id)
        {
            return _context.MessStationen.Any(e => e.Id == id);
        }
    }
}
