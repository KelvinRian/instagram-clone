using InstagramClone.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace InstagramClone.Infra.Data.Mapping
{
    public class ProfilePictureMapping : IEntityTypeConfiguration<ProfilePicture>
    {
        public void Configure(EntityTypeBuilder<ProfilePicture> builder)
        {
            builder.ToTable("ProfilePicture");

            builder.HasKey(x => x.Id);

            builder.Property(x => x.PictureSrc)
                .IsRequired();

            builder.Property(x => x.CreatedAt)
                .IsRequired();

            builder.Property(x => x.Removed)
                .HasDefaultValue(false)
                .IsRequired();
        }
    }
}
