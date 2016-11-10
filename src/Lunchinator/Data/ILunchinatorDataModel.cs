using Microsoft.EntityFrameworkCore;

using SM.Lunchinator.Data.Entities;

namespace SM.Lunchinator.Data
{
	public interface ILunchinatorDataModel
    {
		// Pluralizing the tables just reads better when using Linq.

		DbSet<Person> People { get; set; }

		DbSet<Preference> Preferences { get; set; }

		DbSet<Restaurant> Restaurants { get; set; }

	    void Commit();
    }
}