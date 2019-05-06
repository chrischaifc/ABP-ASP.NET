using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace MYABP.EntityFrameworkCore
{
    public static class MYABPDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<MYABPDbContext> builder, string connectionString)
        {
            builder.UseSqlServer(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<MYABPDbContext> builder, DbConnection connection)
        {
            builder.UseSqlServer(connection);
        }
    }
}
