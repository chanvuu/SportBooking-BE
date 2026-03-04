using System;
using System.Collections.Generic;
using System.Text;

namespace SportBooking.Domain.Enums
{
    public enum BookingStatus
    {
        Pending = 0,
        Accepted = 1,
        Rejected = 2,
        PendingPayment = 3,
        Paid = 4,
        Cancelled = 5
    }
}
