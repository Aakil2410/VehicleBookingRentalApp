using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using System;
using VehicleBookingRentalApp.Domain;

namespace VehicleBookingRentalApp.Services.RentalAddons.Dto
{
    [AutoMap(typeof(RentalAddon))]
    public class RentalAddonDto : EntityDto<Guid>
    {
        public string Option { get; set; }

        public string Details { get; set; }

        public decimal? Cost { get; set; }
    }
}
