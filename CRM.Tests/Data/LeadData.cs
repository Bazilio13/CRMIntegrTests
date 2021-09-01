using CRM.Core.Enums;
using CRM.Core.Models;
using System;

namespace CRM.Tests.Data
{
    public class LeadData : BaseData
    {
        public static LeadInputModel GetValidLeadInsertInputModelForRegistration(Role role)
        {
            var rnd = _random.Next(1, 1000);
            return new()
            {
                FirstName = "FirstName",
                LastName = "LastName",
                Patronymic = "Patronymic",
                BirthDate = $"08.08.2008",
                Email = $"a{rnd}@{DateTime.Now.ToString(_dateFormat).Replace(" ", "").Replace(":", "")}a.ru",
                Password = "12345678",
                CityId = _random.Next(0, 100),
                PhoneNumber = "9999999",
                Role = role
            };
        }

        public static LeadSignInModel GetLeadSignInModelByEmailAndPassword(string email, string password)
        {
            return new() { Email = email, Password = password };
        }
    }
}
