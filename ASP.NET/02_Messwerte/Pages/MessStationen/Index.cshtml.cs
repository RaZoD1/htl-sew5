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
    public class IndexModel : PageModel
    {
        private readonly _02_Messwerte.Data.MessDataContext _context;

        public IndexModel(_02_Messwerte.Data.MessDataContext context)
        {
            _context = context;
        }

        public IList<MessStation> MessStation { get;set; } = default!;

        public async Task OnGetAsync()
        {
            MessStation = await _context.MessStationen.ToListAsync();
        }
    }
}
