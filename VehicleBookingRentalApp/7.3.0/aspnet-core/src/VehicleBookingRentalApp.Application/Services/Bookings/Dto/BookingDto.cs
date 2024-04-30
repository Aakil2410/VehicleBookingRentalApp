using System;
using Abp.Application.Services.Dto;
using VehicleBookingRentalApp.Domain.Enums;
using VehicleBookingRentalApp.Domain;


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

        public Guid? RentalAddonId { get; set; } // array??
    }
}
