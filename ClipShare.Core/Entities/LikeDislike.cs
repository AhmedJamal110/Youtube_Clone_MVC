namespace ClipShare.Core.Entities
{
    public class LikeDislike
    {
        public ApplicationUser User { get; set; } = default!;
        public int UserId { get; set; }
        public Video Video { get; set; } = default!;
        public int VideoId { get; set; }
        public bool Liked { get; set; } = true;
    }
}
