using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using ReflexoterapiasBackEnd.Infra.DataConfig;
using ReflexoterapiasBackEnd.Infra.Repositories;
using ReflexoterapiasBackEnd.Infra.Repositories.Interfaces;

namespace ReflexoterapiasBackEnd.Infra
{
    public static class DIExtension
    {
        public static void AddInfra(this IServiceCollection services, IConfiguration configuration)
        {
            AddDbContext(services, configuration);
            AddRepositories(services);
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
            services.AddScoped<IUserRepository, UserRepository>();
        }
    }
}
