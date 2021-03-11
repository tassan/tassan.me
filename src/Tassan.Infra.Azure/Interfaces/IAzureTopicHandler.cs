using System.Threading.Tasks;

namespace Tassan.Infra.Azure.Interfaces
{
    public interface IAzureTopicHandler
    {
        Task<string> SendMessageToTopicAsync(string messageContent);
    }
}