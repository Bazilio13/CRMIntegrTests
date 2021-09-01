using CRM.Core;
using CRM.Core.Enums;
using CRM.Core.Models;
using CRM.Tests.Constants;
using CRM.Tests.Data;

namespace CRM.Tests.Creators
{
    public class AuthenticationCreator : BaseCreator
    {
        public string SignInByEmailAndPasswordReturnToken(string email, string password)
        {
            _endPoint = AuthorizationEndpoints.SignInEndpoint;
            var postData = LeadData.GetLeadSignInModelByEmailAndPassword(email, password);
            var request = _requestHelper.CreatePostRequest(_endPoint, postData);
            return _client.Execute<string>(request).Data;
        }

        public UserInfo RegisterUser(Role role, string token)
        {
            _endPoint = AuthorizationEndpoints.RegisterEndpoint;
            var newUser = LeadData.GetValidLeadInsertInputModelForRegistration(role);

            var request = _requestHelper.CreatePostRequest(_endPoint, newUser, token);

            var responce = _client.Execute<LeadOutputModel>(request);
            var user = responce.Data;
            return new()
            {
                Id = user.Id,
                Email = newUser.Email,
                Password = newUser.Password,
                Token = token
            };
        }
    }
}
