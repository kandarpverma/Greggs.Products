using Greggs.Products.Api.DataAccess;
using Greggs.Products.Api.Models;
using Greggs.Products.Api.Services;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using System;

namespace Greggs.Products.UnitTests
{
    public class Helper
    {
        private static IServiceProvider Provider()
        {
            var services = new ServiceCollection();

            services.AddLogging();

            services.AddScoped<IProductService, ProductService>()
                .AddScoped<IDataAccess<Product>, ProductAccess>();

            return services.BuildServiceProvider();
        }

        public static T GetRequiredService<T>()
        {
            var provider = Provider();
            return provider.GetService<T>();
        }
    }
}
