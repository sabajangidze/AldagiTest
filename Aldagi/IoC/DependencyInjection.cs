using Aldagi.Filters;
using Application.Services.Policies;
using Application.Services.Policies;
using Domain.Abstractions;
using Infrastructure;
using Infrastructure.Data;
using Infrastructure.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Diagnostics;

namespace Aldagi.IoC
{
    public static class DependencyInjection 
    {
        public static IServiceCollection AddPresentation(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddServices();
            services.AddDbContext(configuration);

            return services;
        }

        private static void AddServices(this IServiceCollection services)
        {
            services.AddScoped<PolicyService>();
        }

        private static void AddDbContext(this IServiceCollection services, IConfiguration configuration)
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
