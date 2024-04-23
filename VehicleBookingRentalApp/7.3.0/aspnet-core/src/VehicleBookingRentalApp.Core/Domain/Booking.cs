using Abp.Domain.Entities.Auditing;
using System;
using VehicleBookingRentalApp.Domain.Enums;

namespace VehicleBookingRentalApp.Domain
{
    public class Booking : FullAuditedEntity<Guid>
    {
        public virtual DateTime? DateOfBooking { get; set; }

        public virtual string RentalPeriod { get; set; }  // calculated >> max 1 year 

        public virtual DateTime? StartDate {  get; set; }

        public virtual DateTime? EndDate { get; set; }

        public virtual CollectionType? CollectionType { get; set; }

        public virtual DateTime? CollectionDate { get; set; }

        public virtual string PickUpLocation { get; set; }

        public virtual string DeliveryLocation { get; set; }

        public virtual decimal? RentalCost { get; set; }

        public virtual Person Person { get; set; }  // Person id

        public virtual Vehicle Vehicle { get; set; } // Vehicle id

        public virtual RentalAddon RentalAddon { get; set; } // array??

    }
}
