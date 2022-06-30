using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace API_DBTryout.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public DbSet<Shop> Shops { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
    }
}