using System;

namespace InstagramClone.Domain.Entities
{
    public class PostComment : BaseEntity
    {
        public string Message { get; private set; }
        public DateTime CreatedAt { get; private set; }
        public DateTime? UpdatedAt { get; private set; }
        public bool Deleted { get; private set; }
        public Guid PostId { get; private set; }
        public Guid UserId { get; private set; }
    }
}
