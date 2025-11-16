using eCommerce.Core.RepositoryContracts;
using eCommerce.Infrastructure.DbContext;
using eCommerce.Infrastructure.Repositories;
using Microsoft.Extensions.DependencyInjection;

namespace eCommerce.Infrastructure
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services)
        {
            // TODO: add Infrastructure services to IoC container
            services.AddSingleton<IUsersRepository, UsersRepository>();
            services.AddSingleton<DapperDbContext>();
            return services;
        }
    }
}
