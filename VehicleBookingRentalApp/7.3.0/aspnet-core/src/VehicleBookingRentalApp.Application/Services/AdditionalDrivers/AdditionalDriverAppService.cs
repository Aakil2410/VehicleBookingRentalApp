using Abp.Application.Services;
using Abp.Domain.Repositories;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq.Dynamic.Core;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using VehicleBookingRentalApp.Domain;
using VehicleBookingRentalApp.Services.AdditionalDrivers.Dto;
using VehicleBookingRentalApp.Services.Bookings.Dto;

namespace VehicleBookingRentalApp.Services.AdditionalDrivers
{
    public class AdditionalDriverAppService : ApplicationService, IAdditionalDriverAppService
    {
        private readonly IRepository<AdditionalDriver, Guid> _repository;
        private readonly IRepository<Person, Guid> _personRepository;
        private readonly IRepository<Booking, Guid> _bookingRepository;

        public AdditionalDriverAppService(IRepository<AdditionalDriver, Guid> repository,
                                          IRepository<Person, Guid> personRepository,
                                          IRepository<Booking, Guid> bookingRepository)
        {
            _repository = repository;
            _personRepository = personRepository;
            _bookingRepository = bookingRepository;
        }

        [HttpPost]
        public async Task<AdditionalDriverDto> CreateAsync(AdditionalDriverDto input)
        {
            var additionalDriver = ObjectMapper.Map<AdditionalDriver>(input);
            additionalDriver.Person = await _personRepository.GetAsync((Guid)input.PersonId.Value);
            additionalDriver.Booking = await _bookingRepository.GetAsync((Guid)input?.BookingId.Value);
            var response = await _repository.InsertAsync(additionalDriver);
            await CurrentUnitOfWork.SaveChangesAsync();
            return ObjectMapper.Map<AdditionalDriverDto>(response);
        }

        [HttpGet]
        public async Task<AdditionalDriverDto> GetAsync(Guid id)
        {
            return ObjectMapper.Map<AdditionalDriverDto>(await _repository.GetAllIncluding(x => x.Person, y => y.Booking).FirstOrDefaultAsync());
        }


        [HttpGet]
        public async Task<List<AdditionalDriverDto>> GetAllAsync()
        {
            return ObjectMapper.Map<List<AdditionalDriverDto>>(_repository.GetAllIncluding(x => x.Person, y => y.Booking));
        }

        [HttpPatch]
        public async Task<AdditionalDriverDto> UpdateAsync(AdditionalDriverDto input)
        {
            var additionalDriver = await _repository.GetAllIncluding(x => x.Person, y => y.Booking).FirstOrDefaultAsync();
            additionalDriver = ObjectMapper.Map(input, additionalDriver);
            additionalDriver.Person = input.PersonId != null ? await _personRepository.GetAsync((Guid)input.PersonId) : additionalDriver.Person;
            additionalDriver.Booking = input.BookingId != null ? await _bookingRepository.GetAsync((Guid)input.BookingId) : additionalDriver.Booking;
            var response = await _repository.UpdateAsync(additionalDriver);
            await CurrentUnitOfWork.SaveChangesAsync();
            return ObjectMapper.Map<AdditionalDriverDto>(response);
        }

        public async Task DeleteAsync(Guid id)
        {
            await _repository.DeleteAsync(id);
        }
    }
}
