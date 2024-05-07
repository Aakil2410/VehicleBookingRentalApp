using Abp.Application.Services.Dto;
using System;

namespace VehicleBookingRentalApp.Services.BookedRentalAddons.Dto
{
    public class BookedRentalAddonDto :EntityDto<Guid>
    {
        public Guid? RentalAddonId { get; set; }

        public Guid? BookingId { get; set; }
    }
}
