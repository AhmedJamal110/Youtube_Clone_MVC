namespace ClipShare.Core.Entities
{
    public sealed class Category : BaseEntity
    {
        public string Name { get; set; } = string.Empty;
        public ICollection<Video> Videos { get; set; } = [];
    }
}
