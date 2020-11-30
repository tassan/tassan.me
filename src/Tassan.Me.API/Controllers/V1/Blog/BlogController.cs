using Microsoft.AspNetCore.Mvc;
using Tassan.Me.API.Entities.Blog;

namespace Tassan.Me.API.Controllers.V1.Blog 
{
    [ApiController]
    [ApiVersion("1")]
    [Route("/v{version:apiVersion}/blog")]
    public class BlogController : Controller
    {
        [HttpPost("create")]
        public IActionResult WritePost([FromBody] Post post)
        {
            return Ok(post);
        }

        [HttpGet("read/{id}")]
        public IActionResult ReadPost(string id)
        {
            return Ok(id);
        }

        [HttpPut("edit")]
        public IActionResult EditPost(string id, [FromBody] Post post)
        {
            return Ok(post);
        }

        [HttpDelete("delete/{id}")]
        public IActionResult DeletePost(string id)
        {
            return Ok(id);
        }
    }
}