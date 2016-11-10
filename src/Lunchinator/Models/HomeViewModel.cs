using System.Collections.Generic;

namespace SM.Lunchinator.Models
{
	public class HomeViewModel
    {
		public HomeViewModel()
		{
			Restaurants = new List<RestaurantModel>();
		}

		public IEnumerable<RestaurantModel> Restaurants { get; set; }
	}
}