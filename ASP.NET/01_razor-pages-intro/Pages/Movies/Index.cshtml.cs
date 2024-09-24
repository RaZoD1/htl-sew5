using _01_razor_pages_intro.Data;
using _01_razor_pages_intro.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace _01_razor_pages_intro.Pages.Movies
{
    public class IndexModel : PageModel
    {
        private readonly MoviesDataContext _context;

        public IndexModel(MoviesDataContext context)
        {
            _context = context;
        }

        public IList<Movie> Movie { get; set; } = default!;

        public async Task OnGetAsync()
        {
            Movie = await _context.Movie.ToListAsync();
        }
        
        [BindProperty(SupportsGet = true)]
        public string? SearchString { get; set; }

        
        public SelectList? Genres { get; set; }

        [BindProperty(SupportsGet = true)]
        public string? MovieGenre { get; set; }
    }
}