using System.Collections.Generic;
using System.Linq;

using SM.Lunchinator.Data;
using SM.Lunchinator.Data.Mappers.Interfaces;
using SM.Lunchinator.Models;

namespace SM.Lunchinator.Repositories
{
	public class LunchinatorRepository : ILunchinatorRepository
	{
		private ILunchinatorDataModel _lunchDataModel;
		private IRestaurantDataMapper _restaurantDataMapper;

		public LunchinatorRepository(ILunchinatorDataModel lunchDataModel, IRestaurantDataMapper restaurantDataMapper)
		{
			_lunchDataModel = lunchDataModel;
			_restaurantDataMapper = restaurantDataMapper;
		}

		public void Commit()
		{
			_lunchDataModel.Commit();
		}

		public IEnumerable<RestaurantModel> GetAllRestaurants()
		{
			return _restaurantDataMapper.Map(_lunchDataModel.Restaurants.OrderBy(item => item.Name));
		}

		public RestaurantModel GetRestaurant(int restaurantId)
		{
			var restaurant = _lunchDataModel.Restaurants.FirstOrDefault(item => item.Id == restaurantId);
			RestaurantModel result = null;

			if (restaurant != null)
			{
				result = _restaurantDataMapper.Map(restaurant);
			}
			return result;
		}

		public void IncreaseVisitCount(int restaurantId)
		{
			var restaurant = _lunchDataModel.Restaurants.FirstOrDefault(item => item.Id == restaurantId);

			if (restaurant != null)
			{
				restaurant.Count++;

				Commit();
			}
		}

		//----==== PRIVATE ====--------------------------------------------------------------------

		private void InitializeMockData()
		{
			//_restaurants = new List<RestaurantModel>
			//{
			//	new RestaurantModel() {Name = "Chipotle"},
			//	new RestaurantModel() {Name = "Sweet Tomatoes"},
			//	new RestaurantModel() {Name = "Indian Buffet (India's Clay Oven)"},
			//	new RestaurantModel() {Name = "Heidi's"},
			//	new RestaurantModel() {Name = "Juicy Burger's & Dogs"},
			//	new RestaurantModel() {Name = "Brickyard, The"},
			//	new RestaurantModel() {Name = "Five Guys"},
			//	new RestaurantModel() {Name = "Whichwich"},
			//	new RestaurantModel() {Name = "Mod Pizza"},
			//	new RestaurantModel() {Name = "Noodles & Company"},
			//	new RestaurantModel() {Name = "Firehouse Subs"},
			//	new RestaurantModel() {Name = "Tokyou Joe's"},
			//	new RestaurantModel() {Name = "Jabo's BBQ (SCONUTS!)"},
			//	new RestaurantModel() {Name = "Pho Kang"},
			//	new RestaurantModel() {Name = "Park Meadow's Mall"},
			//	new RestaurantModel() {Name = "Costa Vida"}
			//};

			//_restaurants.Sort();
		}
	}
}