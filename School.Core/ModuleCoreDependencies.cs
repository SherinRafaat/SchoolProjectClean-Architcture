using Microsoft.Extensions.DependencyInjection;
using School.Services.Abstracts;
using School.Services.Implementations;
using System.Reflection;

namespace School.Core
{
    public static class ModuleCoreDependencies
    {
        public static IServiceCollection AddCoreDependencies(this IServiceCollection services)
        {
            services.AddMediatR(efg => efg.RegisterServicesFromAssemblies(Assembly.GetExecutingAssembly()));
            services.AddAutoMapper(Assembly.GetExecutingAssembly());


            return services;
        }


    }
}
