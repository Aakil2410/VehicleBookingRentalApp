using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleBookingRentalApp.Domain.Enums
{
    public enum TransactionType : int
    {
        [Description("Rental Fee")]
        RentalFee = 1,

        [Description("Late Return")]
        LateReturn = 2,

        [Description("Refund")]
        Refund = 3
    }
}
