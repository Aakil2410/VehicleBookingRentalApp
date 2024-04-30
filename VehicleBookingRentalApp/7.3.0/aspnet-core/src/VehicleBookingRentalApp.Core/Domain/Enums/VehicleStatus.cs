using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleBookingRentalApp.Domain.Enums
{
    public enum VehicleStatus : int
    {
        [Description("Available")]
        Available = 1,

        [Description("Booked")]
        Booked = 2,

        [Description("Maintenance")]
        Maintenance = 3,

        [Description("Unavailable")]
        Male = 4,

        [Description("Out of Service")]
        OutOfServicce = 5
    }
}
