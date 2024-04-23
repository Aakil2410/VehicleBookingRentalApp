using System.ComponentModel;

namespace VehicleBookingRentalApp.Domain.Enums
{
    public enum PaymentStatus : int
    {
        [Description("Pending")]
        Pending = 1,

        [Description("Paid")]
        Paid = 2
    }
}
