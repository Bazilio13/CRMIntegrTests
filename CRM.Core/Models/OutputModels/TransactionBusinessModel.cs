using CRM.Core.Enums;
using System;

namespace CRM.Core.Models
{
    public class TransactionBusinessModel
    {
        public int Id { get; set; }
        public int AccountId { get; set; }
        public Currency Currency { get; set; }
        public TransactionType TransactionType { get; set; }
        public DateTime Date { get; set; }
        public decimal Amount { get; set; }
    }
}
