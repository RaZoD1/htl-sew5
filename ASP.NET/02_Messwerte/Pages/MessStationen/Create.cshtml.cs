using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using _02_Messwerte.Data;
using _02_Messwerte.Model;

namespace _02_Messwerte.Pages.MessStationen
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
            return Page();
        }

        [BindProperty]
        public MessStation MessStation { get; set; } = default!;

        // For more information, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            Console.Out.WriteLine($"Create MessStation");
            if (!ModelState.IsValid)
            {
                return Page();
            }
            Console.Out.WriteLine($"Create MessStation after validate");

            _context.MessStationen.Add(MessStation);
            await _context.SaveChangesAsync();

            Console.Out.WriteLine($"Create MessStation after save");

            return RedirectToPage("./Index");
        }
    }
}
