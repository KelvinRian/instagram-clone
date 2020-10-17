using System;

namespace InstagramClone.Domain.Entities
{
    public class UserFollower : BaseEntity
    {
        public Guid FollowerId { get; private set; }
        public Guid FollowingId { get; private set; }
    }
}