using System.ComponentModel;

namespace VehicleBookingRentalApp.Domain.Enums
{
    public enum CollectionType : int
    {
        [Description("Delivery")]
        Delivery = 1,

        [Description("Pick up")]
        PickUp = 2
    }
}
