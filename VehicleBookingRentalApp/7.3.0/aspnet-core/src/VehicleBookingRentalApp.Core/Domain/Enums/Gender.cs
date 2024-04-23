using System.ComponentModel;

namespace VehicleBookingRentalApp.Domain.Enums
{
    public enum Gender : int
    {
        [Description("Male")]
        Male = 1,

        [Description("Female")]
        Female = 2,

        [Description("Other")]
        Other = 3,

        [Description("Prefer not to say")]
        NotDisclosed = 4
    }
}
