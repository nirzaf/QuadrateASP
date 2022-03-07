using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace Quadrate.EntityFrameworkCore
{
    public static class QuadrateDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<QuadrateDbContext> builder, string connectionString)
        {
            builder.UseSqlServer(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<QuadrateDbContext> builder, DbConnection connection)
        {
            builder.UseSqlServer(connection);
        }
    }
}
