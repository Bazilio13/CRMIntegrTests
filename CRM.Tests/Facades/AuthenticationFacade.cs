using CRM.Core.Enums;
using CRM.Core.Models;
using CRM.Tests.Creators;

namespace CRM.Tests.Facades
{
    public class AuthenticationFacade
    {
        private readonly AuthenticationCreator _creator;
        private const string _email = "Admin@a.com";
        private const string _password = "12345678";

        public AuthenticationFacade() { _creator = new AuthenticationCreator(); }

        public string SignInByAdmin()
        {
            return GetTokenByEmailAndPassword(email: _email, password: _password);
        }

        public UserInfo SignInByAdminAndRegistrationNewUserByRole(Role role)
        {
            var token = GetTokenByEmailAndPassword(email: _email, password: _password);
            var userInfo = RegisterUser(role, token);
            userInfo.Token = token;
            return userInfo;
        }

        public UserInfo RegisterNewUserAndSignIn(Role role)
        {
            var token = GetTokenByEmailAndPassword(email: _email, password: _password);
            var userInfo = RegisterUser(role, token);
            userInfo.Token = GetTokenByEmailAndPassword(userInfo.Email, userInfo.Password);
            return userInfo;
        }

        public string GetTokenByEmailAndPassword(string email, string password)
        {
            return _creator.SignInByEmailAndPasswordReturnToken(email, password);
        }

        public UserInfo RegisterUser(Role role, string token)
        {
            return _creator.RegisterUser(role, token);
        }
    }
}
