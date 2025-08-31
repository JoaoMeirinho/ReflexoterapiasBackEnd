using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Configuration;


namespace ReflexoterapiasBackEnd.Application
{
    public static class DIExtension
    {
        public static void AddApplication(this IServiceCollection serviceDescriptors, IConfiguration configuration)
        {

        }

        public static void AddAutoMapper(IServiceCollection services)
        {
            services.AddScoped(option => new AutoMapper.MapperConfiguration(options =>
            {
                options.AddProfile(new AutoMapping());
            }).CreateMapper());
        }
    }
}
