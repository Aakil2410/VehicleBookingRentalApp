using Abp.Domain.Entities.Auditing;
using System;

namespace VehicleBookingRentalApp.Domain
{
    public class AdditionalDriver : FullAuditedEntity<Guid>
    {
        public virtual Person Person { get; set; }

        public virtual Booking Booking { get; set; }

    }
}
