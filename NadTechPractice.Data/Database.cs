using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

using System.Linq;

namespace NadTechPractice.Data
{
    public class Database
    {
        public static void Initialize(IApplicationBuilder app)
        {
            var context = app.ApplicationServices.CreateScope().ServiceProvider.GetRequiredService<NadTechPracticeContext>();

            if (context.Database.GetPendingMigrations().Any())
            {
                context.Database.MigrateAsync().Wait();
            }
        }
    }
}
