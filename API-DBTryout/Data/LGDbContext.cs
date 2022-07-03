using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace API_DBTryout.Data
{
    public class LGDbContext : IdentityDbContext
    {
        public DbSet<Shop> Shops { get; set; }
        public DbSet<Shul> Shuls { get; set; }

        public LGDbContext(DbContextOptions<LGDbContext> options)
            : base(options)
        {
        }
    }
}