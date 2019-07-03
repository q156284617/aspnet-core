using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using WebProject.Configuration;
using WebProject.Web;

namespace WebProject.EntityFrameworkCore
{
    /* This class is needed to run "dotnet ef ..." commands from command line on development. Not used anywhere else */
    public class WebProjectDbContextFactory : IDesignTimeDbContextFactory<WebProjectDbContext>
    {
        public WebProjectDbContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<WebProjectDbContext>();
            var configuration = AppConfigurations.Get(WebContentDirectoryFinder.CalculateContentRootFolder());

            WebProjectDbContextConfigurer.Configure(builder, configuration.GetConnectionString(WebProjectConsts.ConnectionStringName));

            return new WebProjectDbContext(builder.Options);
        }
    }
}
