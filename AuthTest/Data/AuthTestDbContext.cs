using AuthTest.Models;
using Microsoft.EntityFrameworkCore;
using System.Reflection.Metadata.Ecma335;

namespace AuthTest.Data
{
    public class AuthTestDbContext : DbContext
    {
        public AuthTestDbContext(DbContextOptions<AuthTestDbContext> options) : base(options) 
        {
            
        }
        public DbSet<Merchant> Merchants { get; set; }


    }
}
