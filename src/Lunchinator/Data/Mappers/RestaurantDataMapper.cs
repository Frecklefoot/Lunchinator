using Microsoft.Extensions.DependencyInjection;

using SM.DataMappers.Common;
using SM.Lunchinator.Data.Mappers.Interfaces;
using BO = SM.Lunchinator.Models;
using DM = SM.Lunchinator.Data.Entities;

namespace DotNetCoreAzure.DataMappers
{
	public class RestaurantDataMapper : DataMapper<BO.RestaurantModel, DM.Restaurant>, IRestaurantDataMapper
	{
		public RestaurantDataMapper(IServiceCollection serviceCollection)
			: base(serviceCollection)
		{
		}

		public override BO.RestaurantModel Map(DM.Restaurant entity)
		{
			return new BO.RestaurantModel
			{
				Count = entity.Count,
				Id = entity.Id,
				Name = entity.Name
			};
		}

		public override DM.Restaurant Map(BO.RestaurantModel businessObject)
		{
			return new DM.Restaurant
			{
				Count = businessObject.Count,
				Id = businessObject.Id,
				Name = businessObject.Name
			};
		}
	}
}