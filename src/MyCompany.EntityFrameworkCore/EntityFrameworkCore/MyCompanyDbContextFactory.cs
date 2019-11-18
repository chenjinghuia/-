using MyCompany.Configuration;
using MyCompany.Web;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace MyCompany.EntityFrameworkCore
{
    /* This class is needed to run EF Core PMC commands. Not used anywhere else */
    public class MyCompanyDbContextFactory : IDesignTimeDbContextFactory<MyCompanyDbContext>
    {
        public MyCompanyDbContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<MyCompanyDbContext>();
            var configuration = AppConfigurations.Get(WebContentDirectoryFinder.CalculateContentRootFolder());

            DbContextOptionsConfigurer.Configure(
                builder,
                configuration.GetConnectionString(MyCompanyConsts.ConnectionStringName)
            );

            return new MyCompanyDbContext(builder.Options);
        }
    }
}