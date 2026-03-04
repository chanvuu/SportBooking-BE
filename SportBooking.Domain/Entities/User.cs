using SportBooking.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace SportBooking.Domain.Entities
{
    public class User
    {
        public Guid Id { get; set; }
        public string Email { get; set; }
        public string PasswordHash { get; set; }
        public string FullName { get; set; }
        public Role Role { get; set; }
        public string? GoogleId { get; set; }
        public bool IsActive { get; set; }
        public DateTime CreatedAt { get; set; }
        public User() { }
    }
}
