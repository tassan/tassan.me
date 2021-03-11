using Microsoft.Extensions.DependencyInjection;
using Tassan.Messaging.API.Registry;

namespace Tassan.Messaging.API.Configurations
{
    public static class DependencyInjectionConfig
    {
        public static void ConfigureContainer(IServiceCollection services)
        {
            EntityRegistry.Load(services);
        }
    }
}