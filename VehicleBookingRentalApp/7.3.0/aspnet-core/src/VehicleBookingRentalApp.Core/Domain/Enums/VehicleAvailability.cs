using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleBookingRentalApp.Domain.Enums
{
    public enum VehicleAvailability : int
    {
        [Description("Available")]
        Available = 1,

        [Description("Booked")]
        Booked = 2,

        [Description("In Maintenance")]
        Maintenance = 3,

        [Description("In Reapirs")]
        Reapirs = 4,

        [Description("Unavailable")]
        Male = 5,

        [Description("Out of Service")]
        OutOfServicce = 6
    }
}
