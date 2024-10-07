using Microsoft.EntityFrameworkCore;
using ReptiBuddy.Models.Domain;

namespace ReptiBuddy.Data
{
	public class ReptileDbContext : DbContext
	{
		public ReptileDbContext(DbContextOptions options) : base(options)
		{
		}

		public DbSet<Reptile_Species> Reptile_Species { get; set; }
		public DbSet<Reptile_Type> Reptile_Type { get; set; }
		public DbSet<User_Reptiles> User_Reptiles { get; set; }
		
	}
}