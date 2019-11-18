using Abp.AspNetCore.Mvc.Views;

namespace MyCompany.Web.Views
{
    public abstract class MyCompanyRazorPage<TModel> : AbpRazorPage<TModel>
    {
        protected MyCompanyRazorPage()
        {
            LocalizationSourceName = MyCompanyConsts.LocalizationSourceName;
        }
    }
}
