using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using ReflexoterapiasBackEnd.Infra.DataConfig;

namespace ReflexoterapiasBackEnd.Infra
{
    public static class DIExtension
    {
        public static void AddInfra(this IServiceCollection services)
        {

        }

        public static void AddDbContext(IServiceCollection services, IConfiguration config)
        {
            var connectionString = config.GetConnectionString("Database");
            var serverVersion = ServerVersion.AutoDetect(connectionString);

            services.AddDbContext<ReflexoDBContext>(dbContextOptions =>
            {
                dbContextOptions.UseMySql(connectionString, serverVersion);
            });
        }

        private static void AddRepositories(IServiceCollection services)
        {
            
        }
    }
}
