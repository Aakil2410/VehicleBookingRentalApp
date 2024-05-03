using Abp.Domain.Entities.Auditing;
using System;

namespace VehicleBookingRentalApp.Domain
{
    public class BookingRentalAddon : FullAuditedEntity<Guid>
    {
        public virtual Booking Booking { get; set; }

        public virtual RentalAddon RentalAddon { get; set; }

    }
}
