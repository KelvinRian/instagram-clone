using InstagramClone.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace InstagramClone.Infra.Data.Mapping
{
    public class UserMapping : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.ToTable("User");

            builder.HasKey(x => x.Id);

            builder.Property(x => x.Name)
                .HasMaxLength(70)
                .IsRequired();

            builder.Property(x => x.UserName)
                .HasMaxLength(30)
                .IsRequired();

            builder.Property(x => x.Password)
                .IsRequired();

            builder.Property(x => x.Bio)
                .HasMaxLength(255)
                .IsRequired();

            builder.Property(x => x.Deleted)
                .HasDefaultValue(false)
                .IsRequired();

            builder.HasOne(x => x.ProfilePicture)
                .WithOne(x => x.User)
                .OnDelete(DeleteBehavior.Restrict)
                .HasForeignKey<ProfilePicture>(x => x.UserId);
        }
    }
}
