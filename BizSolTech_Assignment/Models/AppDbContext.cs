using Microsoft.EntityFrameworkCore;

namespace BizSolTech_Assignment.Models
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }
        public DbSet<Developer> developers { get; set; }
    }
}
