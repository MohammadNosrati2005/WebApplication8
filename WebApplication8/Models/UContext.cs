using Microsoft.EntityFrameworkCore;

namespace WebApplication8.Models;

public class UContext : DbContext
{
    public UContext(DbContextOptions<UContext> options)
    : base(options)
    {
    }
        
    public DbSet<University> Universities { get; set; }

}
