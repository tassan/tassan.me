using Newtonsoft.Json;

namespace Tassan.Messaging.API.Models
{
    public class MessageViewModel
    {
        [JsonProperty("content")] public string Content { get; private set; }

        public MessageViewModel(string content) => Content = content;

        public bool IsValid() => !string.IsNullOrEmpty(Content);
    }
}