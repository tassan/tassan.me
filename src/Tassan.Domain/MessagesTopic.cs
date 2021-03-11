using System;

namespace Tassan.Domain
{
    public class MessagesTopic
    {
        public string ServiceBusConnectionString { get; set; }
        public string TopicName { get; set; }
        public string SubscriptionName { get; set; }
    }   
}