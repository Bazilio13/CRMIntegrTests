namespace CRM.Core.Models
{
    public class UserInfo : LeadSignInModel
    {
        public int Id { get; set; }
        public string Token { get; set; }
    }
}
