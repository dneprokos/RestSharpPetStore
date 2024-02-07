using Newtonsoft.Json;

namespace Dneprokos.RestApi.Framework.Models.User
{
    public class UserApiModelV2
    {
        [JsonProperty("id")]
        public int? Id { get; set; }

        [JsonProperty("username")]
        public string? UserName { get; set; }

        [JsonProperty("firstName")]
        public string? FirstName { get; set; }

        [JsonProperty("lastName")]
        public string? LastName { get; set; }

        [JsonProperty("email")]
        public string? Email { get; set; }

        [JsonProperty("password")]
        public string? Password { get; set; }

        [JsonProperty("phone")]
        public string? Phone { get; set; }

        [JsonProperty("userStatus")]
        public int? UserStatus { get; set; }
    }
}
