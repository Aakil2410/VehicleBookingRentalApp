using Abp.Domain.Entities.Auditing;
using System;

namespace VehicleBookingRentalApp.Domain
{
    public class Vehicle : FullAuditedEntity<Guid>
    {
        public virtual string Make {  get; set; }

        public virtual string Model { get; set; }

        public virtual string Year { get; set; }

        public virtual int Mileage { get; set; } // string??

        public virtual string Color { get; set; }

        public virtual decimal Price { get; set; }
    }
}
