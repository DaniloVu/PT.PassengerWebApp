using Microsoft.Extensions.DependencyInjection;
using PT.PassengerWebApp.Data.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PT.PassengerWebApp.Data
{
    public static class DependencyResolver
    {
        public static IServiceCollection ResolveRepositoriesInjection(this IServiceCollection services)
        {
            services.AddScoped<IPassengerRepository, PassengerRepository>();

            return services;
        }
    }
}