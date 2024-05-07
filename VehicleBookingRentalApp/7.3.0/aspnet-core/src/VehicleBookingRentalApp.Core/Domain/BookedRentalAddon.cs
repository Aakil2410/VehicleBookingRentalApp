using Abp.Domain.Entities.Auditing;
using System;

namespace VehicleBookingRentalApp.Domain
{
    public class BookedRentalAddon : FullAuditedEntity<Guid>
    {
        public virtual RentalAddon RentalAddon { get; set; }

        public virtual Booking Booking { get; set; }
    }
}
