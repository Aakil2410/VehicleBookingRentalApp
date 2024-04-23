using System.ComponentModel;

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
        Male = 4
    }
}
