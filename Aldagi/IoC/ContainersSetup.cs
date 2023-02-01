using Aldagi.Filters;
using Domain.Abstractions;
using Infrastructure;
using Infrastructure.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Diagnostics;

namespace Aldagi.IoC
{
    public static class ContainersSetup 
    {
        public static void Setup(IServiceCollection services, IConfiguration configuration)
        {
            AddServices(services);
            AddDbContext(services, configuration);
        }

        private static void AddServices(IServiceCollection services)
        {
        }

        private static void AddDbContext(IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<ApplicationDbContext>(options =>
            {
                options.UseLazyLoadingProxies();
                options.UseSqlServer(configuration.GetConnectionString("ConnectionString"))
                       .ConfigureWarnings(warnings => warnings.Ignore(CoreEventId.LazyLoadOnDisposedContextWarning)).EnableSensitiveDataLogging();
            });

            services.AddScoped<IUnitOfWork>(ctx => new UnitOfWork(ctx.GetRequiredService<ApplicationDbContext>()));

            services.AddScoped<IActionTransactionHelper, ActionTransactionHelper>();
            services.AddScoped<UnitOfWorkFilterAttribute>();
        }
    }
}
