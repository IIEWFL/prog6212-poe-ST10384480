using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using P3CMCS.Models;

namespace P3CMCS.Data
{
    public class P3CMCSContext : IdentityDbContext
    {
        public P3CMCSContext(DbContextOptions<P3CMCSContext> options)
            : base(options)
        {
        }

        public DbSet<Claim> Claims { get; set; } // Add this line to your context
    }
}