using Abp.EntityFrameworkCore;
using Abp.Modules;
using Abp.Reflection.Extensions;

namespace MyCompany.EntityFrameworkCore
{
    [DependsOn(
        typeof(MyCompanyCoreModule), 
        typeof(AbpEntityFrameworkCoreModule))]
    public class MyCompanyEntityFrameworkCoreModule : AbpModule
    {
        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(MyCompanyEntityFrameworkCoreModule).GetAssembly());
        }
    }
}