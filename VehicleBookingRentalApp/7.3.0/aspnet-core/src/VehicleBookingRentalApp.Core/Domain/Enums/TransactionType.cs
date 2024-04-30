using System.ComponentModel;

namespace VehicleBookingRentalApp.Domain.Enums
{
    public enum TransactionType : int
    {
        [Description("Deposit")]
        Deposit = 1,

        [Description("Rental Balance")]
        RentalBalance = 2,

        [Description("Rental Fee")]
        RentalFee = 3,

        [Description("Return")]
        Return = 4,

        [Description("Refund")]
        Refund = 5,

        [Description("Late Return")]
        LateReturn = 6
    }
}
