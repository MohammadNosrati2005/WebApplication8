using InputApp.Models;
using Microsoft.EntityFrameworkCore;
using WebApplication8.Models;
using Microsoft.EntityFrameworkCore.Design;
namespace WebApplication8.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext()
        {
        }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<InputData> inputDatas { get; set; }
        
    }
}
