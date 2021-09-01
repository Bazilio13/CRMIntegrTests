using CRM.Core.Enums;
using System.Collections.Generic;

namespace CRM.Core.Models
{
    public class AccountOutputModel
    {
        public int Id { get; set; }
        public Currency Currency { get; set; }
        public string CreatedOn { get; set; }
        public decimal Balance { get; set; }
        public List<TransactionBusinessModel> Transactions { get; set; }
    }
}