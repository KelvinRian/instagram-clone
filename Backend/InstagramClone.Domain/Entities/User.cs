using System;
using System.Collections.Generic;

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
        public Guid? ProfilePictureId { get; private set; }
        public ProfilePicture ProfilePicture { get; private set; }
        public IEnumerable<UserFollower> Followers { get; private set; }
        public IEnumerable<UserFollower> Following { get; private set; }
        public IEnumerable<Post> Posts { get; private set; }
        public IEnumerable<PostLike> LikesOnPosts { get; private set; }
        public IEnumerable<PostComment> CommentsOnPosts { get; private set; }
    }
}