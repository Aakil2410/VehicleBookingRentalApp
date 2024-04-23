using Abp.Domain.Entities.Auditing;
using System;

namespace VehicleBookingRentalApp.Domain
{
    public class Document : FullAuditedEntity<Guid>
    {
        // save docs in person tbl
        public virtual string DocumentName { get; set; }

        public virtual Person Person { get; set; }

        public virtual AdditionalDriver AdditionalDriver { get; set; }

        public virtual Booking Booking { get; set; }
    }
}
