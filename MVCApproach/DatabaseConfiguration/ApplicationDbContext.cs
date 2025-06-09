using Microsoft.EntityFrameworkCore;
using MVCApproach.Models.Entity;

namespace MVCApproach.DatabaseConfiguration
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public virtual DbSet<Product> Products { get; set; }
    }
}
