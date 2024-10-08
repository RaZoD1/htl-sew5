using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using _02_Messwerte.Data;
using _02_Messwerte.Model;

namespace _02_Messwerte.Pages.MessWerte
{
    public class CreateModel : PageModel
    {
        private readonly _02_Messwerte.Data.MessDataContext _context;

        public CreateModel(_02_Messwerte.Data.MessDataContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
        ViewData["StationId"] = new SelectList(_context.MessStationen, "Id", "Name");
            return Page();
        }

        [BindProperty]
        public MessWert MessWert { get; set; } = default!;

        // For more information, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                Console.Out.WriteLine(String.Join("\n", ModelState.Values.SelectMany(v => v.Errors).Select(e => e.ErrorMessage)));
                return Page();
            }

            _context.MessWert.Add(MessWert);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
