namespace Dneprokos.RestApi.Framework.Utils
{
    public class EndpointPaths
    {
        public static string PetResourceUrl() => "/pet";

        public static string PetByIdResourceUrl(long petId) 
            => $"{PetResourceUrl()}/{petId}";
    }
}
