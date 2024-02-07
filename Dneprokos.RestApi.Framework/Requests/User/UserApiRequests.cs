using Dneprokos.RestApi.Framework.Models.User;
using Dneprokos.RestApi.Framework.Utils;
using Newtonsoft.Json;
using RestSharp;

namespace Dneprokos.RestApi.Framework.Requests.User
{
    public class UserApiRequests : ApiRequestBase
    {
        public UserApiRequests(string baseUrl) : base(baseUrl)
        {
        }

        public RestResponse ExecutePostUserRequest(UserApiModelV2 body)
        {
            var request = new RestRequest(EndpointPaths.UserResourceUrl(), Method.Post);
            request.AddHeaders(Headers);
            string stringJson = JsonConvert.SerializeObject(body);
            request.AddBody(stringJson);
            
            return Client!.Execute(request);
        }
    }
}
