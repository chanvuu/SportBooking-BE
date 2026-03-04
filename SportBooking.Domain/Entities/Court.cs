using System;
using System.Collections.Generic;
using System.Text;

namespace SportBooking.Domain.Entities
{
    public class Court
    {
        public Guid Id { get; set; }
        public Guid OwnerId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal PricePerHour { get; set; }
        public string ImageUrl { get; set; }
        public bool IsOpen { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}
