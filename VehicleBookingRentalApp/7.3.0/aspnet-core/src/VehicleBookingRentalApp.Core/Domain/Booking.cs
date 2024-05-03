using System;
using System.Collections.Generic;
using Abp.Domain.Entities.Auditing;
using VehicleBookingRentalApp.Domain.Enums;

namespace VehicleBookingRentalApp.Domain
{
    public class Booking : FullAuditedEntity<Guid>
    {
        public virtual DateTime? DateOfBooking { get; set; }

        public virtual DateTime? StartDate {  get; set; }

        public virtual DateTime? EndDate { get; set; }

        public virtual DateTime? CollectionDate { get; set; }

        public virtual CollectionType? CollectionType { get; set; }

        public virtual string PickUpLocation { get; set; }

        public virtual string DeliveryLocation { get; set; }

        public virtual decimal? RentalCost { get; set; }

        public virtual decimal? Deposit { get; set; }

        public virtual BookingStatus? BookingStatus { get; set; }


        public virtual Person Person { get; set; }  // Person id

        public virtual Vehicle Vehicle { get; set; } // Vehicle id

        public virtual List<BookingAdditionalDriver> AdditionalDrivers { get; set; } // array??
    }
}
