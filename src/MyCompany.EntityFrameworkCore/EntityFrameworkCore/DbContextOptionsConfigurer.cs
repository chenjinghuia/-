using Microsoft.EntityFrameworkCore;

namespace MyCompany.EntityFrameworkCore
{
    public static class DbContextOptionsConfigurer
    {
        public static void Configure(
            DbContextOptionsBuilder<MyCompanyDbContext> dbContextOptions, 
            string connectionString
            )
        {
            /* This is the single point to configure DbContextOptions for MyCompanyDbContext */
            dbContextOptions.UseSqlServer(connectionString);
        }
    }
}
