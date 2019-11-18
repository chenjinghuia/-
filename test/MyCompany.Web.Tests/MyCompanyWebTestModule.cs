using Abp.AspNetCore.TestBase;
using Abp.Modules;
using Abp.Reflection.Extensions;
using MyCompany.Web.Startup;
namespace MyCompany.Web.Tests
{
    [DependsOn(
        typeof(MyCompanyWebModule),
        typeof(AbpAspNetCoreTestBaseModule)
        )]
    public class MyCompanyWebTestModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.UnitOfWork.IsTransactional = false; //EF Core InMemory DB does not support transactions.
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(MyCompanyWebTestModule).GetAssembly());
        }
    }
}