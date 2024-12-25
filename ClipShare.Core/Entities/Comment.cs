namespace ClipShare.Core.Entities
{
    public  class Comment
    {
        public ApplicationUser User { get; set; } = default!;
        public int UserId { get; set; }

        public Video Video { get; set; } = default!;
        public int VideoId { get; set; }

        public string Content { get; set; } = string.Empty;
        public DateTime PostedAt { get; set; } = DateTime.UtcNow;
    }
}
