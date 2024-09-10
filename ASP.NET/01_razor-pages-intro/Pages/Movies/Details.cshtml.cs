using _01_razor_pages_intro.Data;
using _01_razor_pages_intro.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace _01_razor_pages_intro.Pages.Movies
{
    public class DetailsModel : PageModel
    {
        private readonly MoviesDataContext _context;

        public DetailsModel(MoviesDataContext context)
        {
            _context = context;
        }

        public Movie Movie { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var movie = await _context.Movie.FirstOrDefaultAsync(m => m.Id == id);
            if (movie == null)
            {
                return NotFound();
            }
            else
            {
                Movie = movie;
            }

            return Page();
        }
    }
}