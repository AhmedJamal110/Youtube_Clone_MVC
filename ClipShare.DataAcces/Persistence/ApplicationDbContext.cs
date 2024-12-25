using ClipShare.Core.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace ClipShare.DataAcces.Persistence
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser , ApplicationRole , int>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) :base(options)
        {
            
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
            base.OnModelCreating(builder);
        }

        public DbSet<Category> Categories  { get; set; }
        public DbSet<Channel> Channels  { get; set; }
        public DbSet<Video> Videos  { get; set; }
     
    }
}
