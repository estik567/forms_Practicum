using forms.Repositories.Entities;
using forms.Repositories.Interfaces;
using forms.Repositories.Repositories;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace forms.Repositories
{
    public static class ServicesCollectionExtention
    {
        public static IServiceCollection AddRepositories(this IServiceCollection services)
        {
            services.AddScoped<IDataRepository<User>, UserRepositories>();
            services.AddScoped<IDataRepository<Child>, ChildRepositories>();
            return services;
        }
    }
}
