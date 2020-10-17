using System;

namespace InstagramClone.Domain.Entities
{
    public class PostLike : BaseEntity
    {
        public Guid PostId { get; private set; }
        public Guid UserId { get; private set; }
    }
}