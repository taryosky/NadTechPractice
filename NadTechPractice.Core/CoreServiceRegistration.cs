using Microsoft.Extensions.DependencyInjection;

using NadTechPractice.Contracts.Services;
using NadTechPractice.Core.Services;

using System.Reflection;

namespace NadTechPractice.Core
{
    public static class CoreServiceRegistration
    {
        public static IServiceCollection ConfigureServices(this IServiceCollection services)
        {
            services.AddScoped<ICustomerService, CustomerService>();
            services.AddScoped<IOrderService, OrderService>();
            services.AddAutoMapper(Assembly.GetExecutingAssembly());
            return services;
        }
    }
}
