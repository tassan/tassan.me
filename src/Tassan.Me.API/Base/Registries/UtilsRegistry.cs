using Microsoft.Extensions.DependencyInjection;
using Tassan.Me.API.Base.Interfaces;

namespace Tassan.Me.API.Base.Registries
{
    public static class UtilsRegistry
    {
        public static void Load(IServiceCollection services)
        {
            services.AddScoped<IPostWriter, PostWriter>();
        }
    }
}