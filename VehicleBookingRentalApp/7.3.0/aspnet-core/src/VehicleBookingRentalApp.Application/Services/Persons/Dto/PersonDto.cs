using System;
using Abp.Application.Services.Dto;
using VehicleBookingRentalApp.Domain.Enums;

namespace VehicleBookingRentalApp.Services.Persons.Dto
{
    public class PersonDto : EntityDto<Guid>
    {
        public string Name { get; set; }

        public string Surname { get; set; }

        public string FullName { get; protected set; } // protected?

        public Gender? Gender { get; set; }

        public DateTime? DOB { get; set; } //?? type??

        public string IDNumber { get; set; }

        public string ContactNumber { get; set; }

        public string Address { get; set; }

        public string Email { get; set; }

        public decimal? Credit { get; set; }

        public bool? AdditionalDriver { get; set; }


        // Employee 
        public string EmployeeNumber { get; set; }

        public Department? Department { get; set; }


        public long? UserId { get; set; }

    }
}
