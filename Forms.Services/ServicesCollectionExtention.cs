using forms.Repositories;
using forms.Repositories.Entities;
using Forms.Common.Dto_s;
using Forms.Services.Interfaces;
using Forms.Services.Services;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Forms.Services
{
    public static class ServicesCollectionExtention
    {
        public static IServiceCollection AddServices(this IServiceCollection services)
        {
            services.AddRepositories();
            services.AddScoped<IDataService<UserDto>, UserService>();
            services.AddScoped<IDataService<ChilDto>, ChildService>();
            services.AddSingleton<IContext, EstiKpracticumContext>();

            services.AddAutoMapper(typeof(MappingProfile));
            return services;
        }
    }
}
