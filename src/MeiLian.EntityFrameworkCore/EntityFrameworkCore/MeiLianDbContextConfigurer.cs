using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace MeiLian.EntityFrameworkCore
{
    public static class AbpZeroTemplateDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<AbpZeroTemplateDbContext> builder, string connectionString)
        {
            builder.UseSqlServer(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<AbpZeroTemplateDbContext> builder, DbConnection connection)
        {
            builder.UseSqlServer(connection);
        }
    }
}