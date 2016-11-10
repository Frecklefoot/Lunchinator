using SM.DataMappers.Common;

using BO = SM.Lunchinator.Models;
using DM = SM.Lunchinator.Data.Entities;

namespace SM.Lunchinator.Data.Mappers.Interfaces
{
    public interface IRestaurantDataMapper : IMapper<BO.RestaurantModel, DM.Restaurant>
	{
    }
}