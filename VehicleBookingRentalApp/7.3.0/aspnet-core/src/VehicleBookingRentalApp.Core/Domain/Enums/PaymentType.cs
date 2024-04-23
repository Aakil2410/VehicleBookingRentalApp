using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleBookingRentalApp.Domain.Enums
{
    public enum  PaymentType : int
    {
        [Description("Once off")]
        OnceOff = 1,

        [Description("Daily")]
        Daily = 2,

        [Description("Weekly")]
        Weekly = 3,

        [Description("Monthly")]
        Male = 4,

        [Description("Female")]
        Female = 2,
    }
}
