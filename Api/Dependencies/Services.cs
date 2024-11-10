using Infrastructure.context;
using Microsoft.EntityFrameworkCore;

namespace Api.Dependencies
{
    public static class Services
    {
        public static void ServiceConfiguration(this IServiceCollection services,IConfiguration configuration)
        {
            services.AddDbContext<AppDbCOntext>(options => options.UseSqlServer(configuration.GetConnectionString("dbconn")));
        }
    }
}
