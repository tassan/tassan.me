using Microsoft.Extensions.DependencyInjection;
using Tassan.Messaging.API.Models;

namespace Tassan.Messaging.API.Registry
{
    public static class EntityRegistry
    {
        public static void Load(IServiceCollection services)
        {
            services.AddTransient<MessageViewModel>();
        }
    }
}