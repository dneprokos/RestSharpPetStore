using FluentAssertions;
using NUnit.Framework;

namespace Dneprokos.RestApi.Tests.Tests
{
    [SetUpFixture]
    public class GlobalSetup
    {
        public static string? BaseUrl;

        [OneTimeSetUp]
        public void BeforeFixture()
        {
            BaseUrl = TestContext.Parameters["baseUrl"]!;
            BaseUrl.Should().NotBeNullOrEmpty("baseUrl parameter should be specified");
        }
    }
}
