using Dneprokos.RestApi.Framework.Actions;
using Dneprokos.RestApi.Framework.Models.Pet;
using FluentAssertions;
using Newtonsoft.Json;
using NUnit.Framework;
using RestSharp;
using System.Net;

namespace Dneprokos.RestApi.Tests.Tests.Pet
{
    public class GetPetByIdApiTests : PetApiTestsBase
    {
        [Test]
        public void GetFirstPet_IdExists_ShouldBeReturned()
        {
            // Arrange
            PetApiModelV2 expectedResponse = PetActionRequests.CreateNewPet(BaseUrl!);

            // Act
            RestResponse response = PetApiRequests!.ExecuteApiGetPetByIdRequest(expectedResponse.Id!.Value);

            // Assert
            response.StatusCode.Should().Be(HttpStatusCode.OK);
            var responseBody = JsonConvert.DeserializeObject<PetApiModelV2>(response.Content!);
            responseBody.Should().NotBeNull();
            responseBody.Should().BeEquivalentTo(expectedResponse);
        }
    }
}
