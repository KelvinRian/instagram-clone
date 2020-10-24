using System;

namespace InstagramClone.Domain.Entities
{
    public class ProfilePicture : BaseEntity
    {
        public string PictureSrc { get; private set; }
        public DateTime CreatedAt { get; private set; }
        public Guid UserId { get; private set; }
        public User User { get; private set; }
        public bool Removed { get; private set; }
    }
}
