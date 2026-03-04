using SportBooking.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace SportBooking.Domain.Entities
{
    public class Booking
    {
        public Guid Id { get; set; }
        public Guid CourtId { get; set; }
        public Guid UserId { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public decimal TotalAmount { get; set; }
        public BookingStatus Status { get; set; }
        public DateTime? ExpiresAt { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}
