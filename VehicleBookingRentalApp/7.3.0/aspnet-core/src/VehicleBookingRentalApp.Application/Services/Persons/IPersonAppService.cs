using System.Collections.Generic;
using System.Threading.Tasks;
using System;
using VehicleBookingRentalApp.Services.Persons.Dto;
using Abp.Application.Services;

namespace VehicleBookingRentalApp.Services.Persons
{
    public interface IPersonAppService : IApplicationService
    {
        Task<PersonDto> CreateAsync(CreatePersonDto input);

        Task<PersonDto> GetAsync(Guid id);

        Task<List<PersonDto>> GetAllAsync();

        Task<PersonDto> UpdateAsync(PersonDto input);

        Task DeleteAsync(Guid id);
    }
}
