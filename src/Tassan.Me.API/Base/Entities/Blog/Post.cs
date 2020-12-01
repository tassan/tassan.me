using Tassan.Me.API.Base.Objects;

namespace Tassan.Me.API.Base.Entities.Blog
{
    public class Post : BlogEntity
    {
        public string Title { get; set; }
        public string Summary { get; set; }
        public string Body { get; set; }
        public string[] Tags { get; set; }
    }
}