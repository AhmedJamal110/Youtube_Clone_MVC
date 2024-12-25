using ClipShare.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ClipShare.DataAcces.Persistence.Configration
{
    public class VideoConfigration : IEntityTypeConfiguration<Video>
    {
        public void Configure(EntityTypeBuilder<Video> builder)
        {
            builder.Property(video => video.ThumbnailUrl).IsRequired();
            builder.Property(video => video.Title).IsRequired();
            builder.Property(video => video.Descrioption).IsRequired();
            builder.Property(video => video.ContentType).IsRequired();
            builder.Property(video => video.Contents).IsRequired();

            builder.HasOne(video => video.Category)
                     .WithMany(cat => cat.Videos)
                     .HasForeignKey(video => video.CategoryId);

            builder.HasOne(video => video.Channel)
                  .WithMany(channel => channel.Videos)
                  .HasForeignKey(video => video.ChannelId);
        }
    }
}
