namespace ClipShare.Core.Entities
{
    public sealed class Channel : BaseEntity
    {
        public string Name { get; set; } = string.Empty;
        public string About { get; set; } = string.Empty;
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

        // user
        public ApplicationUser User { get; set; } = default!;
        public int UserId { get; set; }

        // video
        public ICollection<Video> Videos { get; set; } = [];

        public ICollection<Subscribe> Subscribers { get; set; } = [];
    }
    

}
