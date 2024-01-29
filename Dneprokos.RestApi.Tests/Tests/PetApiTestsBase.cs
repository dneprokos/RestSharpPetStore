using Dneprokos.RestApi.Framework.Requests.Pet;
using NUnit.Framework;

namespace Dneprokos.RestApi.Tests.Tests
{
    [TestFixture]
    public abstract class PetApiTestsBase
    {
        protected PetApiRequests? PetApiRequests;
        protected static string? BaseUrl;

        [OneTimeSetUp]
        public void BeforeFixture()
        {
            BaseUrl = GlobalSetup.BaseUrl;
            PetApiRequests = new PetApiRequests(BaseUrl!);
        }
    }
}
