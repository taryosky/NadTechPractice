using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

using NadTechPractice.Contracts.Repositories;
using NadTechPractice.Data.Repository;

namespace NadTechPractice.Data
{
    public static class DataServiceRegistration
    {
        public static IServiceCollection ConfigureDbContext(this IServiceCollection services, IConfiguration configuration)
            => services.AddDbContext<NadTechPracticeContext>(option => option.UseSqlite(configuration.GetConnectionString("NadTechPracticeData")));

        public static IServiceCollection ConfigureRepositories(this IServiceCollection services) =>
            services.AddScoped<IRepositoryManager, RepositoryManager>();
    }
}
