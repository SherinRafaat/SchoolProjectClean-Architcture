using Microsoft.Extensions.DependencyInjection;
using School.infrastructure.Abstracts;
using School.infrastructure.Repos;

namespace School.infrastructure
{
    public static class ModuleInfrastructureDependencies
    {
        public static IServiceCollection AddInfrastructureDependencies(this IServiceCollection services)
        {
            services.AddTransient<IStudentRepository, StudentRepository>();

            return services;
        }


    }
}
