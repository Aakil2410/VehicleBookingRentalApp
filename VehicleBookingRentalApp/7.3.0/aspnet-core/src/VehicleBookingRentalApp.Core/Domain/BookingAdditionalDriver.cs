using Abp.Domain.Entities.Auditing;
using System;

namespace VehicleBookingRentalApp.Domain
{
    public class BookingAdditionalDriver : FullAuditedEntity<Guid>
    {
        public virtual Person Person { get; set; }

        public virtual Booking Booking { get; set; }

    }
}
