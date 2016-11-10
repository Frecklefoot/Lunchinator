using System.Collections.Generic;

using SM.Lunchinator.Models;

namespace SM.Lunchinator.Repositories
{
	public interface ILunchinatorRepository
	{
		void Commit();

		void IncreaseVisitCount(int restaurantId);

	    IEnumerable<RestaurantModel> GetAllRestaurants();

		RestaurantModel GetRestaurant(int restaurantId);
	}
}