using System.Threading.Tasks;
using Quadrate.Models.TokenAuth;
using Quadrate.Web.Controllers;
using Shouldly;
using Xunit;

namespace Quadrate.Web.Tests.Controllers
{
    public class HomeController_Tests: QuadrateWebTestBase
    {
        [Fact]
        public async Task Index_Test()
        {
            await AuthenticateAsync(null, new AuthenticateModel
            {
                UserNameOrEmailAddress = "admin",
                Password = "123qwe"
            });

            //Act
            var response = await GetResponseAsStringAsync(
                GetUrl<HomeController>(nameof(HomeController.Index))
            );

            //Assert
            response.ShouldNotBeNullOrEmpty();
        }
    }
}