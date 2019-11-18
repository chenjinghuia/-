using System;
using System.Threading.Tasks;
using Abp.TestBase;
using MyCompany.EntityFrameworkCore;
using MyCompany.Tests.TestDatas;

namespace MyCompany.Tests
{
    public class MyCompanyTestBase : AbpIntegratedTestBase<MyCompanyTestModule>
    {
        public MyCompanyTestBase()
        {
            UsingDbContext(context => new TestDataBuilder(context).Build());
        }

        protected virtual void UsingDbContext(Action<MyCompanyDbContext> action)
        {
            using (var context = LocalIocManager.Resolve<MyCompanyDbContext>())
            {
                action(context);
                context.SaveChanges();
            }
        }

        protected virtual T UsingDbContext<T>(Func<MyCompanyDbContext, T> func)
        {
            T result;

            using (var context = LocalIocManager.Resolve<MyCompanyDbContext>())
            {
                result = func(context);
                context.SaveChanges();
            }

            return result;
        }

        protected virtual async Task UsingDbContextAsync(Func<MyCompanyDbContext, Task> action)
        {
            using (var context = LocalIocManager.Resolve<MyCompanyDbContext>())
            {
                await action(context);
                await context.SaveChangesAsync(true);
            }
        }

        protected virtual async Task<T> UsingDbContextAsync<T>(Func<MyCompanyDbContext, Task<T>> func)
        {
            T result;

            using (var context = LocalIocManager.Resolve<MyCompanyDbContext>())
            {
                result = await func(context);
                context.SaveChanges();
            }

            return result;
        }
    }
}
