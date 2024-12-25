using ClipShare.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ClipShare.DataAcces.Persistence.Configration
{
    public class SubsribeConfigration : IEntityTypeConfiguration<Subscribe>
    {
        public void Configure(EntityTypeBuilder<Subscribe> builder)
        {
            builder.HasKey(subscribe => new { subscribe.UserId, subscribe.ChannelId });

            builder.HasOne(subscribe => subscribe.User)
                      .WithMany(user => user.Subscriptions)
                      .HasForeignKey(subscribe => subscribe.UserId)
                     .OnDelete(DeleteBehavior.Cascade);

            builder.HasOne(subscribe => subscribe.Channel)
                      .WithMany(user => user.Subscribers)
                      .HasForeignKey(subscribe => subscribe.ChannelId)
                      .OnDelete(DeleteBehavior.Restrict);

        }
    }
}
