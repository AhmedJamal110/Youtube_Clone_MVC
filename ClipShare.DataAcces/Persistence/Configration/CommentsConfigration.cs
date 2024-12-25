using ClipShare.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ClipShare.DataAcces.Persistence.Configration
{
    public class CommentsConfigration : IEntityTypeConfiguration<Comment>
    {
        public void Configure(EntityTypeBuilder<Comment> builder)
        {
            builder.HasKey(comment => new { comment.UserId, comment.VideoId });
         
            builder.HasOne(comment => comment.User)
                       .WithMany(user => user.Comments)
                       .HasForeignKey(comment => comment.UserId)
                       .OnDelete(DeleteBehavior.Cascade);


            builder.HasOne(comment => comment.Video)
                       .WithMany(video => video.Comments)
                       .HasForeignKey(comment => comment.VideoId)
                       .OnDelete(DeleteBehavior.Restrict);

            builder.Property(comment => comment.Content).IsRequired();

        }
    }
}
