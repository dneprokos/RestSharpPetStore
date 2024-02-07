using Dneprokos.RestApi.Framework.Actions;
using Dneprokos.RestApi.Framework.Models.Pet;
using Dneprokos.RestApi.Framework.Utils;
using FluentAssertions;
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
            RestResponse response = PetApi!.PetSection().ExecuteApiGetPetByIdRequest(expectedResponse.Id!.Value);

            // Assert
            response.StatusCode.Should().Be(HttpStatusCode.OK);
            PetApiModelV2 responseBody = response.ConvertToModel<PetApiModelV2>();
            responseBody.Should().BeEquivalentTo(expectedResponse);
        }
    }
}
