using System;
using Abp.Domain.Entities.Auditing;
using VehicleBookingRentalApp.Domain.Enums;
using VehicleBookingRentalApp.Authorization.Users;
using Microsoft.AspNetCore.Identity;

namespace VehicleBookingRentalApp.Domain
{
    public class Person : FullAuditedEntity<Guid>
    {
        public virtual string Name { get; set; }

        public virtual string Surname { get; set; }

        public virtual string FullName { get; protected set; } // protected?

        public virtual Gender? Gender { get; set; }

        //******
        public virtual DateTime? DOB {  get; set; } //?? type??

        public virtual string IDNumber { get; set; }

        public virtual string ContactNumber { get; set; }

        public virtual string Address { get; set; }

        public virtual string Email { get; set; }

        public virtual decimal? Credit { get; set; }

        /// <summary>
        /// Indicates whether the booking is for an additional driver. Default value is false.
        /// </summary>
        public virtual bool? IsAdditionalDriver { get; set; } = false;



        // Employee 
        public virtual string EmployeeNumber { get; set; }

        public virtual Department? Department { get; set; }


        public virtual User User { get; set; }

        public override string ToString()
        {
            return FullName;
        }
    }
}
