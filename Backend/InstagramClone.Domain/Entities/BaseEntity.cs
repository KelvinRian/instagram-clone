using System;

namespace InstagramClone.Domain.Entities
{
    public class BaseEntity
    {
        public Guid Id { get; protected set; }
    }
}
