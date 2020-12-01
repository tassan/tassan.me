using Microsoft.Extensions.DependencyInjection;
using Tassan.Me.API.Base.Registries;

namespace Tassan.Me.API.Base.Configuration
{
    public class DependencyInjectionConfig
    {
        public static void ConfigureContainer(IServiceCollection services)
        {
            UtilsRegistry.Load(services);
        }
    }
}