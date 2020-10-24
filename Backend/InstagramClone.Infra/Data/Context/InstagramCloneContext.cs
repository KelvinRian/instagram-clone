using InstagramClone.Infra.Data.Mapping;
using Microsoft.EntityFrameworkCore;

namespace InstagramClone.Infra.Data
{
    public class InstagramCloneContext : DbContext
    {
        public InstagramCloneContext(DbContextOptions<InstagramCloneContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfiguration(new PostCommentMapping());
            modelBuilder.ApplyConfiguration(new PostLikeMapping());
            modelBuilder.ApplyConfiguration(new PostMapping());
            modelBuilder.ApplyConfiguration(new ProfilePictureMapping());
            modelBuilder.ApplyConfiguration(new UserFollowerMapping());
            modelBuilder.ApplyConfiguration(new UserMapping());
        }
    }
}