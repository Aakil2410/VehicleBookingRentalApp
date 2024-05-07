using Abp.Application.Services.Dto;
using System;

namespace VehicleBookingRentalApp.Services.AdditionalDrivers.Dto
{
    public class AdditionalDriverDto : EntityDto<Guid>
    {
        public Guid? PersonId { get; set; }
        public Guid? BookingId { get; set; }
    }
}