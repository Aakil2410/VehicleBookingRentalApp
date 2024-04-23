using Abp.Domain.Entities.Auditing;
using System;
using VehicleBookingRentalApp.Authorization.Users;
using VehicleBookingRentalApp.Domain.Enums;

namespace VehicleBookingRentalApp.Domain
{
    public class Person : FullAuditedEntity<Guid>
    {
        public virtual string Name { get; set; }

        public virtual string Surname { get; set; }

        public virtual string FullName { get; protected set; } // protected?

        public virtual Gender? Gender { get; set; }

        public virtual DateTime? DOB {  get; set; } //?? type??

        public virtual string IDNumber { get; set; }

        public virtual string ContactNumber { get; set; }

        public virtual string Address { get; set; }

        public virtual string Email { get; set; }

        public virtual User User { get; set; }

        public override string ToString()
        {
            return FullName;
        }
    }
}
