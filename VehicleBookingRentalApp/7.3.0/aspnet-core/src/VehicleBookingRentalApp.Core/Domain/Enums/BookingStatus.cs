using System.ComponentModel;

namespace VehicleBookingRentalApp.Domain.Enums
{
    public enum BookingStatus : int
    {
        [Description("Pending Documents")]
        PendingDocuments = 1,

        [Description("Processing")]
        Processing = 2,

        [Description("Pending Payment")]
        PendingPayment = 3,

        [Description("Complete")]
        Complete = 4,

        [Description("Cancelled")]
        Cancelled = 5,

        [Description("Expired")]
        Expired = 6,

        [Description("On Hold")]
        OnHold = 7,

        [Description("Awaiting Collection")]
        AwaitingCollection = 8,

        [Description("Refund Processing")]
        RefundProcessing = 9,

    }
}
