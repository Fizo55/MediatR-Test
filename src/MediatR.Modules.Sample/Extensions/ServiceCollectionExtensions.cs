using Microsoft.Extensions.DependencyInjection;
using System.Reflection;

namespace MediatR.Modules.Sample.Extensions
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddSampleModule(this IServiceCollection services)
        {
            Console.WriteLine("[Initializing] Sample module ..");
            services.AddMediatR(Assembly.GetExecutingAssembly());
            return services;
        }
    }
}