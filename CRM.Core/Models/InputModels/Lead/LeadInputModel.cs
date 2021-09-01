using CRM.Core.Enums;

namespace CRM.Core.Models
{
    public class LeadInputModel
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Patronymic { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string Password { get; set; }
        public string BirthDate { get; set; }
        public Role Role { get; set; }
        public int CityId { get; set; }
    }
}