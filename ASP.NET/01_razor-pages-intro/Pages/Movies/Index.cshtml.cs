using _01_razor_pages_intro.Data;
using _01_razor_pages_intro.Models;
using Microsoft.AspNetCore.Mvc.RazorPages;
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
    }
}