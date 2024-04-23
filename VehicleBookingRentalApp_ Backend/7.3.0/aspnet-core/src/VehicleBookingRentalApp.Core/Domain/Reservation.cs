using Abp.Domain.Entities.Auditing;
using System;
using VehicleBookingRentalApp.Domain.Enums;

namespace VehicleBookingRentalApp.Domain
{
    public class Reservation : FullAuditedEntity<Guid>
    {
        public virtual DateTime? ReservationDate { get; set; }

        public virtual CollectionType? CollectionType { get; set; }

        public virtual string PickUpLocation { get; set; }  // enum of branch locations

        public virtual string DeliveryLocation { get; set; }

        public virtual string RentalPeriod { get; set; }

        public virtual Person Person { get; set; }

        public virtual Vehicle Vehicle { get; set; }

        public Insurance Insurance { get; set; }

    }
}
