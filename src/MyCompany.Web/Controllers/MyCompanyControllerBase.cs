using Abp.AspNetCore.Mvc.Controllers;

namespace MyCompany.Web.Controllers
{
    public abstract class MyCompanyControllerBase: AbpController
    {
        protected MyCompanyControllerBase()
        {
            LocalizationSourceName = MyCompanyConsts.LocalizationSourceName;
        }
    }
}