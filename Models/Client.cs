using RestSharp;
using RestSharp.Serializers.Json;
using RestSharp.Authenticators;

namespace lab_3.Models
{
    public class Client
    {
        public RestClient client = new RestClient();
        public RestRequest request = new RestRequest();
        public RestResponse response { get; set; }
        public Client() { }
    }
}
