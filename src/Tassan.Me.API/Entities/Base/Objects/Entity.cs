using System;
using Tassan.Me.API.Entities.Base.Interfaces;

namespace Tassan.Me.API.Entities.Base.Objects
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