using brgy_mgmt_dotnet.application.Contracts.Persistence;
using brgy_mgmt_dotnet.infrastructure.Contexts;
using brgy_mgmt_dotnet.infrastructure.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace brgy_mgmt_dotnet.infrastructure
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfrastructureService(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<AppDbContext>(options =>
            {
                options.UseSqlServer(configuration.GetConnectionString("BrgyMgmtDbDevConnection") ?? "");
            });

            services.AddScoped(typeof(IGenericRepository<>), typeof(GenericRepository<>));
            services.AddScoped<IResidentRepository, ResidentRepository>();
            services.AddScoped<IBrgyInfoRepository, BrgyInfoRepository>();

            return services;
        }
    }
}
