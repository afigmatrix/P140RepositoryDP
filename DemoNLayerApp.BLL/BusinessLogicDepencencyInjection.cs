
using DemoNLayerApp.BLL.Service.Impl;
using DemoNLayerApp.BLL.Service.Interface;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoNLayerApp.DAL
{
    public static class BusinessLogicDepencencyInjection
    {
        public static void BusinessLogicInjection(this IServiceCollection services)
        {
            services.AddScoped<IProductService, ProductService>();
            services.AddScoped<IAuthService, AuthService>();
            services.AddScoped<ITokenService, TokenService>();
        }
    }
}
