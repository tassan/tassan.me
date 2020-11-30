using System;
using Tassan.Me.API.Entities.Base.Interfaces;
using Tassan.Me.API.Entities.Blog;

namespace Tassan.Me.API.Entities.Base.Objects
{
    public class BlogEntity : Entity
    {
        public Author Author { get; set; }
    }
}