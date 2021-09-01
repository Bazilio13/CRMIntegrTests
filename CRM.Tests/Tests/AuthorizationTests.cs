using CRM.Core;
using CRM.Core.Enums;
using CRM.Core.Models;
using CRM.Tests.Constants;
using CRM.Tests.Creators;
using CRM.Tests.Data;
using CRM.Tests.Facades;
using FluentAssertions;
using NUnit.Framework;
using System.Net;

namespace CRM.Tests.Tests
{
    public class AuthenticationTest: BaseTest
    {
        private AuthenticationCreator _authentication = new();

        private readonly AuthenticationFacade _authenticationFacade = new();
        public AuthenticationTest()
        {
            //_authentication = new();
        }

        [TestCase(Role.Admin)]
        public void Register(Role role)
        {
            //Given
            var lead = LeadData.GetValidLeadInsertInputModelForRegistration(role);
            var request = _requestHelper.CreatePostRequest(AuthorizationEndpoints.RegisterEndpoint, lead);

            //When
            var response = _client.Execute<LeadOutputModel>(request);

            //Then
            response.StatusCode.Should().Be(HttpStatusCode.Created);
            response.Data.Should().BeEquivalentTo(lead, options => options
            .Excluding(o => o.Password)
            .Excluding(o => o.CityId));
            response.Data.City.Id.Should().Be(lead.CityId);
            response.Data.City.Name.Should().NotBeNullOrEmpty();
        }
    }
}
