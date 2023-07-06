using Microsoft.Extensions.DependencyInjection;
using PT.PassengerWebApp.Services.PassengerValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PT.PassengerWebApp.Services
{
    public static class DependencyResolver
    {
        public static IServiceCollection ResolveRepositoriesInjection(this IServiceCollection services)
        {
            services.AddScoped<IPassengerFormValidator, PassengerFormValidator>();

            return services;
        }
    }
}