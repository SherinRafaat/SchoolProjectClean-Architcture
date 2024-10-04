using Microsoft.Extensions.DependencyInjection;
using School.infrastructure.Abstracts;
using School.infrastructure.Repos;
using School.Services.Abstracts;
using School.Services.Implementations;

namespace School.Services
{
    public static class ModuleServicesDependencies
    {
   
            public static IServiceCollection AddServicesDependencies(this IServiceCollection services)
            {
                services.AddTransient<IStudentServices, StudentServices>();

                return services;
            }


        


    }
}
