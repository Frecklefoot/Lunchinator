using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

using SM.Lunchinator.Data;
using SM.Lunchinator.Data.Mappers;
using SM.Lunchinator.Data.Mappers.Interfaces;

namespace SM.Lunchinator.Repositories
{
    public static class IServiceCollectionExtensions
    {
	    public static void AddLunchRepository(this IServiceCollection services, IConfigurationRoot configuration)
	    {
			services.AddScoped<ILunchinatorDataModel, LunchinatorDbContext>();
			services.AddScoped<ILunchinatorRepository, LunchinatorRepository>();

			services.AddTransient<IRestaurantDataMapper, RestaurantDataMapper>();

			services.AddEntityFramework().AddDbContext<LunchinatorDbContext>(options => options.UseSqlServer(configuration["ConnectionStrings.DefaultConnection"]));
		}
	}
}