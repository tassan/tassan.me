using System;
using Tassan.Me.API.Base.Interfaces;

namespace Tassan.Me.API.Base.Objects
{
    public class Entity : IEntity
    {
        public Guid Id { get; set; }

        protected Entity()
        {
            Id = Guid.NewGuid();
        }
    }
}