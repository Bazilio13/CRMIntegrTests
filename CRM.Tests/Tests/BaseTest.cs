using CRM.Core;
using NUnit.Framework;
using RestSharp;

namespace CRM.Tests.Tests
{
    public abstract class BaseTest
    {
        protected const string BaseEndpoint = "https://localhost:44374/api/";
        protected string _endPoint;
        protected RestClient _client;
        protected RequestHelper _requestHelper;

        [SetUp]
        public void Setup()
        {
            _client = new RestClient(BaseEndpoint);
            _requestHelper = new RequestHelper();
        }
    }
}
