using Abp.Application.Services;
using Abp.Domain.Repositories;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System;
using System.Threading.Tasks;
using VehicleBookingRentalApp.Domain;
using VehicleBookingRentalApp.Services.Vehicles.Dto;

namespace VehicleBookingRentalApp.Services.Vehicles
{
    public class VehicleAppService : ApplicationService, IVehicleAppService
    {
        private readonly IRepository<Vehicle, Guid> _repository;

        public VehicleAppService(IRepository<Vehicle, Guid> repository)
        {
            _repository = repository;
        }

        [HttpPost]
        public async Task<VehicleDto> CreateAsync(VehicleDto input)
        {
            var vehicle = ObjectMapper.Map<Vehicle>(input); 
            vehicle = await _repository.InsertAsync(vehicle);
            await CurrentUnitOfWork.SaveChangesAsync();
            return ObjectMapper.Map<VehicleDto>(vehicle);
        }

        [HttpGet]
        public async Task<VehicleDto> GetAsync(Guid id)
        {
            return ObjectMapper.Map<VehicleDto>(await _repository.GetAsync(id));
        }

        [HttpGet]
        public async Task<List<VehicleDto>> GetAllAsync()
        {
            return ObjectMapper.Map<List<VehicleDto>>(await _repository.GetAllListAsync());
        }

        [HttpPatch]
        public async Task<VehicleDto> UpdateAsync(VehicleDto input)
        {
            var vehicle = await _repository.GetAsync(input.Id);
            ObjectMapper.Map(input, vehicle);
            vehicle = await _repository.UpdateAsync(vehicle);
            await CurrentUnitOfWork.SaveChangesAsync();
            return ObjectMapper.Map<VehicleDto>(vehicle);
        }

        [HttpDelete]
        public async Task DeleteAsync(Guid id)
        {
            await _repository.DeleteAsync(id);
        }
    }
}
