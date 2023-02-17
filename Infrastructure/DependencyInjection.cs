using Application.Abstractions;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure
{
    public static class DependencyInjection
    {
        public static IServiceCollection Setup(IServiceCollection services)
        {
            services.AddScoped<IEmailServices, EmailServices>();

            return services;
        }
    }
}
