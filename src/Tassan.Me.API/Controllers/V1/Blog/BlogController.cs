using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Tassan.Me.API.Base.Entities.Blog;
using Tassan.Me.API.Base.Interfaces;

namespace Tassan.Me.API.Controllers.V1.Blog 
{
    [ApiController]
    [ApiVersion("1")]
    [Route("/v{version:apiVersion}/blog")]
    public class BlogController : Controller
    {
        private readonly IPostWriter _postWriter;

        public BlogController(IPostWriter postWriter)
        {
            _postWriter = postWriter;
        }

        [HttpPost("create")]
        public async Task<IActionResult> WritePost([FromBody] Post post)
        {
            await _postWriter.WritePost(post);
            
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