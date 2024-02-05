using Microsoft.EntityFrameworkCore;
using RepiBuddy.Models.Domain;

namespace RepiBuddy.Data
{
    public class ReptileDbContext : DbContext
    {
        public ReptileDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Reptile_Species> Reptile_Species { get; set; }
        
	}
}