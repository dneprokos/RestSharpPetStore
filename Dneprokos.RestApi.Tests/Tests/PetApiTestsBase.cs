using Dneprokos.RestApi.Framework.Requests;
using NUnit.Framework;

namespace Dneprokos.RestApi.Tests.Tests
{
    [TestFixture]
    [Parallelizable(ParallelScope.All)]
    public abstract class PetApiTestsBase
    {
        protected PetStoreApiFacade? PetApi;
        protected static string? BaseUrl;

        [OneTimeSetUp]
        public void BeforeFixture()
        {
            BaseUrl = GlobalSetup.BaseUrl;
            PetApi = new PetStoreApiFacade(BaseUrl!);
        }
    }
}
