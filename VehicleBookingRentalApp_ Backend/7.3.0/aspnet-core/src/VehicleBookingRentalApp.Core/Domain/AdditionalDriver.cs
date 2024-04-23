namespace VehicleBookingRentalApp.Domain
{
    public class AdditionalDriver : Person
    {
        public virtual Booking Booking { get; set; }

        public virtual Person Person { get; set; }
    }
}
