using Microsoft.AspNetCore.Identity;

namespace ClipShare.Core.Entities
{
    public class ApplicationUser : IdentityUser<int>
    {
        public string Name { get; set; } = string.Empty;
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

        public Channel Channel { get; set; } = default!;

        public ICollection<Comment> Comments { get; set; } = [];
        public ICollection<Subscribe> Subscriptions { get; set; } = [];

        public ICollection<LikeDislike> LikeDislikes { get; set; } = [];
    }
}
