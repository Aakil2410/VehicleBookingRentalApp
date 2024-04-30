using System;
using System.Threading.Tasks;
using Abp.Application.Services;
using System.Collections.Generic;
using VehicleBookingRentalApp.Services.Persons.Dto;

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
