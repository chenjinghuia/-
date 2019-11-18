using Abp.AspNetCore;
using Abp.AspNetCore.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using MyCompany.Configuration;
using MyCompany.EntityFrameworkCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;

namespace MyCompany.Web.Startup
{
    [DependsOn(
        typeof(MyCompanyApplicationModule), 
        typeof(MyCompanyEntityFrameworkCoreModule), 
        typeof(AbpAspNetCoreModule))]
    public class MyCompanyWebModule : AbpModule
    {
        private readonly IConfigurationRoot _appConfiguration;

        public MyCompanyWebModule(IHostingEnvironment env)
        {
            _appConfiguration = AppConfigurations.Get(env.ContentRootPath, env.EnvironmentName);
        }

        public override void PreInitialize()
        {
            Configuration.DefaultNameOrConnectionString = _appConfiguration.GetConnectionString(MyCompanyConsts.ConnectionStringName);

            Configuration.Navigation.Providers.Add<MyCompanyNavigationProvider>();

            Configuration.Modules.AbpAspNetCore()
                .CreateControllersForAppServices(
                    typeof(MyCompanyApplicationModule).GetAssembly()
                );
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(MyCompanyWebModule).GetAssembly());
        }
    }
}