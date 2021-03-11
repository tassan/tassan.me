using System;
using System.Threading.Tasks;
using Azure.Messaging.ServiceBus;
using Tassan.Domain;
using Tassan.Infra.Azure.Interfaces;

namespace Tassan.Infra.Azure
{
    public class AzureTopicHandler : IAzureTopicHandler
    {
        private readonly MessagesTopic _messagesTopic;

        public AzureTopicHandler(MessagesTopic messagesTopic)
        {
            _messagesTopic = messagesTopic;
        }

        public async Task<string> SendMessageToTopicAsync(string messageContent)
        {
            // create a Service Bus client 
            await using (ServiceBusClient client = new ServiceBusClient(_messagesTopic.ServiceBusConnectionString))
            {
                // create a sender for the topic
                ServiceBusSender sender = client.CreateSender(_messagesTopic.TopicName);
                await sender.SendMessageAsync(new ServiceBusMessage(messageContent));
                Console.WriteLine($"Sent a single message to the topic: {_messagesTopic.TopicName}");
                return $"Message '{messageContent}' Sent at {DateTime.UtcNow}";
            }
        }
    }
}