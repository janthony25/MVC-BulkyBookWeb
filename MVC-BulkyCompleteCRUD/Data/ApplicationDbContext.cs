using Microsoft.EntityFrameworkCore;
using MVC_BulkyCompleteCRUD.Models;

namespace MVC_BulkyCompleteCRUD.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
            
        }

        public DbSet<Category> Categories { get; set; }
    }
}
