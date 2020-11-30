using System;
using Tassan.Me.API.Entities.Base.Objects;

namespace Tassan.Me.API.Entities.Blog
{
    public class Author : Entity
    {
        public string Name { get; set; }
        public string Description { get; set; }
    }
}