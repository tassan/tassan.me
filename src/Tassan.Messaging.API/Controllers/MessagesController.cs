using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Tassan.Infra.Azure.Interfaces;
using Tassan.Messaging.API.Models;

namespace Tassan.Messaging.API.Controllers
{
    [ApiController, ApiVersion("1"), Route("/v{version:apiVersion}/messages")]
    public class MessagesController : Controller
    {
        private readonly IAzureTopicHandler _topicHandler;

        public MessagesController(IAzureTopicHandler topicHandler)
        {
            _topicHandler = topicHandler;
        }

        [HttpPost("send")]
        public async Task<ActionResult<string>> SendMessage([FromBody] string message)
        {
            if (string.IsNullOrEmpty(message)) return BadRequest("Message not sent");
            return Ok(await _topicHandler.SendMessageToTopicAsync(message));
        }
    }
}