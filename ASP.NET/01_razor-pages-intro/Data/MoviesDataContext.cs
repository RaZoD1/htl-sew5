using _01_razor_pages_intro.Models;
using Microsoft.EntityFrameworkCore;

namespace _01_razor_pages_intro.Data
{
    public class MoviesDataContext : DbContext
    {
        public MoviesDataContext (DbContextOptions<MoviesDataContext> options)
            : base(options)
        {
        }

        public DbSet<Movie> Movie { get; set; } = default!;
    }
}