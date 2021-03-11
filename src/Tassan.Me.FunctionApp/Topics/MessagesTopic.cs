using System;
using System.Threading.Tasks;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Host;
using Microsoft.Extensions.Logging;

namespace Tassan.Me.FunctionApp.Topics
{
    public static class MessagesTopic
    {
        [FunctionName("MessagesTopic")]
        public static async Task RunAsync([ServiceBusTrigger("messages", "analyse-message", Connection = "ServiceBusTopicConnectionString")]
            string mySbMsg, ILogger log)
        {
            log.LogInformation($"C# ServiceBus topic trigger function processed message: {mySbMsg}");
        }
    }
}