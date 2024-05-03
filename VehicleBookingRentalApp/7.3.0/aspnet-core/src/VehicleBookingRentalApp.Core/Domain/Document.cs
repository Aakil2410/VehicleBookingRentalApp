using Abp.Domain.Entities.Auditing;
using System;

namespace VehicleBookingRentalApp.Domain
{
    public class Document : FullAuditedEntity<Guid>
    {
 
        public virtual string DocumentName { get; set; }

        //public virtual bool? Valid { get; set; }

        public virtual Person Person { get; set; }

        public virtual AdditionalDriver AdditionalDriver { get; set; }

        public virtual Booking Booking { get; set; }
    }
}
