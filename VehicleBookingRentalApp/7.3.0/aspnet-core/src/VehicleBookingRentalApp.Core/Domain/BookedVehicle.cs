using Abp.Domain.Entities.Auditing;
using System;

namespace VehicleBookingRentalApp.Domain
{
    public class BookedVehicle : FullAuditedEntity<Guid>
    {


        public virtual Booking Booking { get; set; }

        public virtual Person Person { get; set; }

        public virtual Vehicle Vehicle { get; set; }

    }
}
