using Microsoft.Extensions.DependencyInjection;
using Tassan.Infra.Azure;
using Tassan.Infra.Azure.Interfaces;

namespace Tassan.Messaging.API.Extensions
{
    public static class ServiceExtensions
    {
        public static void AddAzureTopicHandler(this IServiceCollection services) =>
            services.AddTransient<IAzureTopicHandler, AzureTopicHandler>();
    }
}