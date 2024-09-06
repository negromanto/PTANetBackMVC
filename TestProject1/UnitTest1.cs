using Microsoft.AspNetCore.Mvc.Testing;
using Microsoft.Extensions.Hosting.Internal;

namespace TestProject1
{
    public class UnitTest1
    {
        [Fact]
        public async void Test1()
        {
            await using var application = new WebApplicationFactory<WebAPI_MVC_ASR.Controllers.FeedController>();
            using var client = application.CreateClient();


            var response = await client.GetStringAsync("/api/Feed");
            Assert.Equal("", response);

        }
    }
}