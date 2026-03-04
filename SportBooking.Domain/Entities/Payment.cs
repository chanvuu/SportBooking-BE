using SportBooking.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace SportBooking.Domain.Entities
{
    public class Payment
    {
        public Guid Id { get; set; }
        public Guid BookingId { get; set; }
        public decimal Amount { get; set; }
        public PaymentStatus Status { get; set; }
        public string? ProofImageUrl { get; set; }
        public Guid? ConfirmedBy { get; set; }
        public DateTime? ConfirmedAt { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}
