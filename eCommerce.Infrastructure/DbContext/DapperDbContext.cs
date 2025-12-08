using Microsoft.Extensions.Configuration;
using Npgsql;
using System.Data;

namespace eCommerce.Infrastructure.DbContext
{
    public class DapperDbContext
    {
        private readonly IConfiguration _configuration;
        private readonly IDbConnection _dbConnection;

        public DapperDbContext(IConfiguration configuration) {
            _configuration = configuration;

            string? connectionString = _configuration.GetConnectionString("PostgresConnection")!
                .Replace("$POSTGRES_HOST", Environment.GetEnvironmentVariable("POSTGRES_HOST"))
                .Replace("$POSTGRES_PORT", Environment.GetEnvironmentVariable("POSTGRES_PORT"))
                .Replace("$POSTGRES_PASSWORD", Environment.GetEnvironmentVariable("POSTGRES_PASSWORD"));

            _dbConnection = new NpgsqlConnection(connectionString);
        }

        public IDbConnection DbConnection => _dbConnection;
    }
}
