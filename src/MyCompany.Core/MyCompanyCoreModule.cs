using Abp.Modules;
using Abp.Reflection.Extensions;
using MyCompany.Localization;

namespace MyCompany
{
    public class MyCompanyCoreModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Auditing.IsEnabledForAnonymousUsers = true;

            MyCompanyLocalizationConfigurer.Configure(Configuration.Localization);
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(MyCompanyCoreModule).GetAssembly());
        }
    }
}