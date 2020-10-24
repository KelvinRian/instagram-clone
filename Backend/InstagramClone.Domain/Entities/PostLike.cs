using System;

namespace InstagramClone.Domain.Entities
{
    public class PostLike : BaseEntity
    {
        public Guid PostId { get; private set; }
        public Post Post { get; private set; }
        public Guid UserId { get; private set; }
        public User User { get; private set; }
    }
}