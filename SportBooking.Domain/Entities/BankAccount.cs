using System;
using System.Collections.Generic;
using System.Text;

namespace SportBooking.Domain.Entities
{
    public class BankAccount
    {
        public Guid Id { get; set; }
        public Guid OwnerId { get; set; }
        public string BankCode { get; set; } 
        public string BankName { get; set; }
        public string AccountNumber { get; set; }
        public string AccountName { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}
