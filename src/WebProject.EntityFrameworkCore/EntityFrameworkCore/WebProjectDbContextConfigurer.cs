using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace WebProject.EntityFrameworkCore
{
    public static class WebProjectDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<WebProjectDbContext> builder, string connectionString)
        {
            builder.UseSqlServer(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<WebProjectDbContext> builder, DbConnection connection)
        {
            builder.UseSqlServer(connection);
        }
    }
}
