using System.ComponentModel;

namespace VehicleBookingRentalApp.Domain.Enums
{
    public enum  PaymentStatus : int
    {
        [Description("Paid")]
        Paid = 1,

        [Description("Pending")]
        Pending = 2
    }
}
