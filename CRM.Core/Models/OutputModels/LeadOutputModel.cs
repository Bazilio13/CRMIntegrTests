using CRM.Core.Enums;
using System.Collections.Generic;

namespace CRM.Core.Models
{
    public class LeadOutputModel
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Patronymic { get; set; }
        public string RegistrationDate { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string Password { get; set; }
        public bool IsDeleted { get; set; }
        public string BirthDate { get; set; }
        public Role Role { get; set; }
        public CityOutputModel City { get; set; }
        public List<AccountOutputModel> Accounts { get; set; }
    }
}