using System;
using System.IO;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Tassan.Me.API.Base.Entities.Blog;
using Tassan.Me.API.Base.Extensions;
using Tassan.Me.API.Base.Interfaces;

namespace Tassan.Me.Infra.Storage
{
    public class PostWriter : IPostWriter
    {
        private readonly IConfiguration _configuration;
        private readonly IWebHostEnvironment _environment;

        private const string PostsDir = @"\_data\_posts\";

        public PostWriter(IConfiguration configuration, IWebHostEnvironment environment)
        {
            _configuration = configuration;
            _environment = environment;
        }

        public async Task WritePost(Post post)
        {
            string rootPath = _environment.ContentRootPath;
            var postsPath = rootPath + PostsDir + GeneratePostFileName(post.Title);

            await using StreamWriter sw = new StreamWriter(postsPath);
            await sw.WriteAsync(post.Body);
        }

        private string GeneratePostFileName(string postTitle)
        {
            var extension = ".md";
            var title = postTitle.Replace(" ", "-")
                .Replace(",", string.Empty)
                .Replace(".", string.Empty)
                .ToLowerInvariant()
                .RemoveAccents();
                
            return $"{title}-{DateTime.Today:yyyy-M-d}{extension}";
        }
    }
}