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
    public class DetailsModel : PageModel
    {
        private readonly _02_Messwerte.Data.MessDataContext _context;

        public DetailsModel(_02_Messwerte.Data.MessDataContext context)
        {
            _context = context;
        }

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
    }
}
