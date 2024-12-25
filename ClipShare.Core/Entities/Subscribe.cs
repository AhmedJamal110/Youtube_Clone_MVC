namespace ClipShare.Core.Entities
{
    public class Subscribe
    {
        public ApplicationUser User { get; set; } = default!;
        public int UserId { get; set; }
        public Channel Channel { get; set; } = default!;
        public int ChannelId { get; set; } 
    }
}
