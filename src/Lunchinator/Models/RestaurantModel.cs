using System;

namespace SM.Lunchinator.Models
{
	public class RestaurantModel : IComparable
	{
		public int Count { get; set; }

		public int Id { get; set; }

		public string Name { get; set; }

		public int CompareTo(object obj)
		{
			var compareTo = obj as RestaurantModel;

			if (compareTo == null)
			{
				throw new InvalidCastException($"Cannot cast {obj.GetType().Name} to {GetType().Name}.");
			}

			return Name.CompareTo(compareTo.Name);
		}
	}
}