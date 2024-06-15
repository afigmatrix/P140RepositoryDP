using DemoNLayerApp.DAL.Context;
using DemoNLayerApp.DAL.Repository;
using DemoNLayerApp.DAL.UnitOfWorkImpl;
using DemoNLayerApp.Domain.Repository;
using DemoNLayerApp.Domain.UnitOfWorkInterface;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace DemoNLayerApp.DAL
{
    public static class DataAccessDepencencyInjection
    {
        public static void DataAccessInjection(this IServiceCollection services,IConfiguration configuration)
        {
            services.AddDbContext<DemoNLayerAppDbContext>(options =>
            {
                options.UseSqlServer(configuration.GetConnectionString("Default"));
            });

            services.AddScoped<IProductRepository, ProductRepository>();
            services.AddScoped<IUnitOfWork, UnitOfWork>();
        }
    }
}
