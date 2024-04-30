using System;
using System.Threading.Tasks;
using Abp.Application.Services;
using System.Collections.Generic;
using VehicleBookingRentalApp.Services.Vehicles.Dto;

namespace VehicleBookingRentalApp.Services.Vehicles
{
    public interface IVehicleAppService : IApplicationService
    {
        Task<VehicleDto> CreateAsync(VehicleDto input);

        Task<VehicleDto> GetAsync(Guid id);

        Task<List<VehicleDto>> GetAllAsync();

        Task<VehicleDto> UpdateAsync(VehicleDto input);

        Task DeleteAsync(Guid id);
    }
}
