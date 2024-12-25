namespace ClipShare.Core.Entities
{
    public sealed class Video : BaseEntity
    {
        public string ThumbnailUrl { get; set; } = string.Empty;
        public string Title { get; set; } = string.Empty;
        public string Descrioption { get; set; } = string.Empty;
        public string ContentType { get; set; } = string.Empty;
        public byte[] Contents { get; set; } = [];

        // channel 
        public Channel Channel { get; set; } = default!;
        public int ChannelId { get; set; }

        // category
        public Category Category { get; set; } = default!;
        public int CategoryId { get; set; }

        public ICollection<Comment> Comments { get; set; } = [];
        public ICollection<LikeDislike> LikeDislikes { get; set; } = [];
    }

}
