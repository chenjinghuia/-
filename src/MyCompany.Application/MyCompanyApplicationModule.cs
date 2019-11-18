using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;

namespace MyCompany
{
    [DependsOn(
        typeof(MyCompanyCoreModule), 
        typeof(AbpAutoMapperModule))]
    public class MyCompanyApplicationModule : AbpModule
    {
        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(MyCompanyApplicationModule).GetAssembly());
        }
    }
}