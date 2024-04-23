using Abp.Domain.Entities.Auditing;
using System;

namespace VehicleBookingRentalApp.Domain
{
    public class BookedVehicles : FullAuditedEntity<Guid>
    {

        public virtual Booking Booking { get; set; }

        public virtual Person Person { get; set; }

        public virtual Vehicle Vehicle { get; set; }

    }
}
