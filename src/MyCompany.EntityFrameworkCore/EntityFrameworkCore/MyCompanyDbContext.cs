using Abp.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using MyCompany.Customers;
using MyCompany.Employee;
using System.Threading.Tasks;

namespace MyCompany.EntityFrameworkCore
{
    public class MyCompanyDbContext : AbpDbContext
    {
        public DbSet<Basic> Basic { get; set; }
        public DbSet<Basic> Certificate { get; set; }
        public DbSet<Basic> Record { get; set; }
        public DbSet<Customer> Customer { get; set; }
        public DbSet<Customer> Order { get; set; }

        public MyCompanyDbContext(DbContextOptions<MyCompanyDbContext> options) 
            : base(options)
        {

        }
    }
}
