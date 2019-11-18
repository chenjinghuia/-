using System.Threading.Tasks;
using MyCompany.Web.Controllers;
using Shouldly;
using Xunit;

namespace MyCompany.Web.Tests.Controllers
{
    public class HomeController_Tests: MyCompanyWebTestBase
    {
        [Fact]
        public async Task Index_Test()
        {
            //Act
            var response = await GetResponseAsStringAsync(
                GetUrl<HomeController>(nameof(HomeController.Index))
            );

            //Assert
            response.ShouldNotBeNullOrEmpty();
        }
    }
}
