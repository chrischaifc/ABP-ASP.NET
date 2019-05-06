using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using MYABP.Configuration;
using MYABP.Web;

namespace MYABP.EntityFrameworkCore
{
    /* This class is needed to run "dotnet ef ..." commands from command line on development. Not used anywhere else */
    public class MYABPDbContextFactory : IDesignTimeDbContextFactory<MYABPDbContext>
    {
        public MYABPDbContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<MYABPDbContext>();
            var configuration = AppConfigurations.Get(WebContentDirectoryFinder.CalculateContentRootFolder());

            MYABPDbContextConfigurer.Configure(builder, configuration.GetConnectionString(MYABPConsts.ConnectionStringName));

            return new MYABPDbContext(builder.Options);
        }
    }
}
