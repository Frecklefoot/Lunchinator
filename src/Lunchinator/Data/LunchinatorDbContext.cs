using Microsoft.EntityFrameworkCore;

using SM.Lunchinator.Data.Entities;

namespace SM.Lunchinator.Data
{
	public class LunchinatorDbContext : DbContext, ILunchinatorDataModel
	{
		public LunchinatorDbContext(DbContextOptions<LunchinatorDbContext> options)
			: base(options) { }

		public DbSet<Person> People { get; set; }

		public DbSet<Preference> Preferences { get; set; }

		public DbSet<Restaurant> Restaurants { get; set; }

		public void Commit()
		{
			SaveChanges();
		}

		//----==== PROTECTED ====------------------------------------------------------------------

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			// Old way...
			//modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();

			modelBuilder.Model.RemoveEntityType("OneToManyCascadeDeleteConvention");
		}
	}
}