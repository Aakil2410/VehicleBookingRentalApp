using Abp.Application.Services;
using System.Collections.Generic;
using System.Threading.Tasks;
using System;
using VehicleBookingRentalApp.Services.Bookings.Dto;
using VehicleBookingRentalApp.Services.AdditionalDrivers.Dto;

namespace VehicleBookingRentalApp.Services.AdditionalDrivers
{
    public interface IAdditionalDriverAppService : IApplicationService
    {
        Task<AdditionalDriverDto> CreateAsync(AdditionalDriverDto input);

        Task<AdditionalDriverDto> GetAsync(Guid id);

        Task<List<AdditionalDriverDto>> GetAllAsync();

        Task<AdditionalDriverDto> UpdateAsync(AdditionalDriverDto input);

        Task DeleteAsync(Guid id);
    }
}
