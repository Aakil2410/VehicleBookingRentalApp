using Abp.Application.Services.Dto;
using System;
using System.Collections.Generic;
using VehicleBookingRentalApp.Domain.Enums;


namespace VehicleBookingRentalApp.Services.Bookings.Dto
{
    public class BookingDto : EntityDto<Guid>
    {
        public DateTime? DateOfBooking { get; set; }

        public DateTime? StartDate { get; set; }

        public DateTime? EndDate { get; set; }

        public int RentalPeriod { get; set; }  // ca]lculated 

        public DateTime? CollectionDate { get; set; }

        public CollectionType? CollectionType { get; set; }

        public string CollectionTypeName { get; set; }

        public string PickUpLocation { get; set; }

        public string DeliveryLocation { get; set; }

        public decimal? RentalCost { get; set; }

        public decimal? Deposit { get; set; }

        public BookingStatus? BookingStatus { get; set; }

        public string StatusName { get; set; }

        public Guid? PersonId { get; set; }  // Person 

        public Guid? VehicleId { get; set; } // Vehicle 

        public List<Guid?> AdditionalDriverIds { get; set; }

        //public List<Guid?> RentalAddonIds { get; set; } // array??
    }
}
