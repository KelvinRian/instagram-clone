using InstagramClone.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace InstagramClone.Infra.Data.Mapping
{
    public class UserFollowerMapping : IEntityTypeConfiguration<UserFollower>
    {
        public void Configure(EntityTypeBuilder<UserFollower> builder)
        {
            builder.ToTable("UserFollower");

            builder.HasKey(x => x.Id);

            builder.HasOne(x => x.Follower)
                .WithMany(x => x.Followers)
                .HasForeignKey(x => x.FollowerId)
                .OnDelete(DeleteBehavior.Restrict)
                .IsRequired();

            builder.HasOne(x => x.Following)
                .WithMany(x => x.Following)
                .HasForeignKey(x => x.FollowingId)
                .OnDelete(DeleteBehavior.Restrict)
                .IsRequired();
        }
    }
}
