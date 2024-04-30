using System.ComponentModel;

namespace VehicleBookingRentalApp.Domain.Enums
{
    public enum Department : int
    {
        [Description("Operations")]
        Operations = 1,

        [Description("Customer Service")]
        CustomerService = 2,

        [Description("Admin")]
        Admin = 3,

        [Description("MAintenance")]
        MAintenance = 4
    }
}
