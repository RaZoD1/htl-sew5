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

namespace _02_Messwerte.Pages.MessWerte
{
    public class EditModel : PageModel
    {
        private readonly _02_Messwerte.Data.MessDataContext _context;

        public EditModel(_02_Messwerte.Data.MessDataContext context)
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

            var messwert =  await _context.MessWert.FirstOrDefaultAsync(m => m.Id == id);
            if (messwert == null)
            {
                return NotFound();
            }
            MessWert = messwert;
           ViewData["StationId"] = new SelectList(_context.MessStationen, "Id", "Id");
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

            _context.Attach(MessWert).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!MessWertExists(MessWert.Id))
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

        private bool MessWertExists(int id)
        {
            return _context.MessWert.Any(e => e.Id == id);
        }
    }
}
