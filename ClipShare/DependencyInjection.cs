using ClipShare.DataAcces.Persistence;
using Microsoft.EntityFrameworkCore;

namespace ClipShare
{
    public  static class DependencyInjection
    {
        public static IServiceCollection AddApplicationServicesConfig(this IServiceCollection services , IConfiguration config)
        {
            services.AddDbContext<ApplicationDbContext>(opt =>
            {
                opt.UseSqlServer(config.GetConnectionString("DefaultConnection");
            });

            return services;
        }
    }
}
