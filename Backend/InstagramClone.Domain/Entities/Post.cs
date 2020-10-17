using System;

namespace InstagramClone.Domain.Entities
{
    public class Post : BaseEntity
    {
        public string FileSrc { get; private set; }
        public string Description { get; private set; }
        public DateTime CreatedAt { get; private set; }
        public DateTime? UpdatedAt { get; private set; }
        public bool Deleted { get; private set; }
        public Guid UserId { get; private set; }
    }
}