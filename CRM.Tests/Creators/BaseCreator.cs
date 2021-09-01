using CRM.Core;
using RestSharp;

namespace CRM.Tests.Creators
{
    public abstract class BaseCreator
    {
        protected const string BaseEndEndpoint = "https://localhost:44374/api/";
        protected string _endPoint;
        protected RequestHelper _requestHelper = new RequestHelper();
        protected RestClient _client = new RestClient(BaseEndEndpoint);
    }
}
