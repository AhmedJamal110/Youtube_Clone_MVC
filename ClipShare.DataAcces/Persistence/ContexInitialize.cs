using Microsoft.EntityFrameworkCore;

namespace ClipShare.DataAcces.Persistence
{
    public static class ContexInitialize
    {
        public static void Initialize(ApplicationDbContext context)
        {
            if (context.Database.GetPendingMigrations().Count() > 0)
            {
                context.Database.Migrate();
            }
        }
    }
}
