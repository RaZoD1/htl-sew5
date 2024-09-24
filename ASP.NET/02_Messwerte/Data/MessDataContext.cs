using _02_Messwerte.Model;
using Microsoft.EntityFrameworkCore;

namespace _02_Messwerte.Data;

public class MessDataContext: DbContext
{
    public MessDataContext(DbContextOptions<MessDataContext> options): base(options){}
    
    public DbSet<MessStation> MessStationen { get; set; }
}
