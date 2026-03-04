using System;
using System.Collections.Generic;
using System.Text;

namespace SportBooking.Domain.Enums
{
    public enum PaymentStatus
    {
        WaitingForProof = 0,
        WaitingForApproval = 1,
        Success = 2,
        Rejected = 3
    }
}
