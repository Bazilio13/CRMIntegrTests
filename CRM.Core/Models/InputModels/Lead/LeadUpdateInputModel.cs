namespace CRM.Core.Models
{
    public class LeadUpdateInputModel
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Patronymic { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string BirthDate { get; set; }
        public CityInputModel City { get; set; }
    }
}