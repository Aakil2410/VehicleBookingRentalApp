using Abp.Domain.Entities.Auditing;
using System;

namespace VehicleBookingRentalApp.Domain
{
    public class Booking : FullAuditedEntity<Guid>
    {
        public virtual DateTime? DateOfBooking { get; set; }

        public virtual string CollectionType { get; set; }

        public virtual string PickUpLocation { get; set; }

        public virtual string DeliveryLocation { get; set; }

        public virtual DateTime? DateOfCollection { get; set; }

        public virtual string RentalPeriod {  get; set; }

        public virtual Person Person { get; set; }

        public virtual Vehicle Vehicle { get; set; }




    }
}
