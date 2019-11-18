using Abp.Application.Services;

namespace MyCompany
{
    /// <summary>
    /// Derive your application services from this class.
    /// </summary>
    public abstract class MyCompanyAppServiceBase : ApplicationService
    {
        protected MyCompanyAppServiceBase()
        {
            LocalizationSourceName = MyCompanyConsts.LocalizationSourceName;
        }
    }
}