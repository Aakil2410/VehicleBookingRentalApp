using Abp.Domain.Entities.Auditing;
using System;
using VehicleBookingRentalApp.Authorization.Users;

namespace VehicleBookingRentalApp.Domain
{
    public class AdditionalDriver : FullAuditedEntity<Guid>
    {
        public virtual string Name { get; set; }

        public virtual string Surname { get; set; }

        public virtual string FullName { get; protected set; } // protected?

        public virtual string IDNumber { get; set; }

        public virtual string ContactNumber { get; set; }

        public virtual string Email { get; set; }

        public override string ToString()
        {
            return FullName;
        }

        public virtual Booking Booking { get; set; }
    }
}

