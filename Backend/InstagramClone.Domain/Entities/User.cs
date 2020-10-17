using System;

namespace InstagramClone.Domain.Entities
{
    public class User : BaseEntity
    {
        public string Name { get; private set; }
        public string UserName { get; private set; }
        public string Email { get; private set; }
        public string Password { get; private set; }
        public string Bio { get; private set; }
        public bool Deleted { get; private set; }
        public Guid? CurrentProfilePictureId { get; private set; }
    }
}