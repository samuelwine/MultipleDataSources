using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace API_DBTryout.Data
{
    public class ERDbContext : IdentityDbContext
    {
        public DbSet<Shop> Shops { get; set; }

        public ERDbContext(DbContextOptions<ERDbContext> options)
            : base(options)
        {
        }
    }
}