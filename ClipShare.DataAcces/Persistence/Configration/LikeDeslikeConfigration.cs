using ClipShare.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ClipShare.DataAcces.Persistence.Configration
{
    public class LikeDeslikeConfigration : IEntityTypeConfiguration<LikeDislike>
    {
        public void Configure(EntityTypeBuilder<LikeDislike> builder)
        {
            builder.HasKey(like => new { like.UserId, like.VideoId });

            builder.HasOne(like => like.User)
                      .WithMany(user => user.LikeDislikes)
                      .HasForeignKey(like => like.UserId)
                      .OnDelete(DeleteBehavior.Cascade);

            builder.HasOne(like => like.Video)
                    .WithMany(video => video.LikeDislikes)
                    .HasForeignKey(like => like.VideoId)
                    .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
