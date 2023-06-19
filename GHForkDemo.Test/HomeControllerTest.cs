using GHForkDemo.Controllers;
using GHForkDemo.Shared.Models.Home;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Moq;

namespace GHForkDemo.Test
{
    public class HomeControllerTest
    {
        private readonly ILogger<HomeController> _logger;

        public HomeControllerTest()
        {
            var mock = new Mock<ILogger<HomeController>>();
            _logger = mock.Object;
        }

        [Fact]
        public void Index()
        {
            var controller = new HomeController(_logger);
            var viewResult = controller.Index(name: "Test") as ViewResult;
            Assert.NotNull(viewResult);
            Assert.NotNull(viewResult.Model);
            Assert.Equal(expected: "Test", actual: (viewResult.Model as IndexModel)?.Name);

        }
    }
}