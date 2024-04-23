using Abp.Domain.Entities.Auditing;
using System;

namespace VehicleBookingRentalApp.Domain
{
    public class Insurance : FullAuditedEntity<Guid>
    {
        public virtual string Type { get; set; }

        public string Description { get; set; }

        public virtual string CoverageDetails { get; set; }

        public virtual decimal Cost { get; set; }

    }
}
