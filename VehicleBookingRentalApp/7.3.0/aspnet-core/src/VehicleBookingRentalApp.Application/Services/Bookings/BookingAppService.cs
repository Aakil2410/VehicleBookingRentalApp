using Abp.Application.Services;
using Abp.Domain.Repositories;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VehicleBookingRentalApp.Domain;
using VehicleBookingRentalApp.Services.Bookings.Dto;
using VehicleBookingRentalApp.Services.Utils;

namespace VehicleBookingRentalApp.Services.Bookings
{
    public class BookingAppService : ApplicationService, IBookingAppService
    {
        private readonly IRepository<Booking, Guid> _repository;
        private readonly IRepository<Person, Guid> _personRepository;
        private readonly IRepository<Vehicle, Guid> _vehicleRepository;
        private readonly IRepository<AdditionalDriver, Guid> _additionalDriverRepository;
        private readonly IRepository<RentalAddon, Guid> _rentalAddonRepository;
        private readonly IRepository<BookedRentalAddon, Guid> _bookedRentalAddonRepository;

        public BookingAppService(IRepository<Booking, Guid> repository,
                                IRepository<Person, Guid> personRepository,
                                IRepository<Vehicle, Guid> vehicleRepository,
                                IRepository<AdditionalDriver, Guid> additionalDriverRepository,
                                IRepository<RentalAddon, Guid> rentalAddonRepository,
                                IRepository<BookedRentalAddon, Guid> bookedRentalAddonRepository)
        {
            _repository = repository;
            _personRepository = personRepository;
            _vehicleRepository = vehicleRepository;
            _additionalDriverRepository = additionalDriverRepository;
            _rentalAddonRepository = rentalAddonRepository;
            _bookedRentalAddonRepository = bookedRentalAddonRepository;
        }

        [HttpPost]
        public async Task<BookingDto> CreateAsync(BookingDto input)
        {
            var booking = ObjectMapper.Map<Booking>(input);
            booking.Person = await _personRepository.GetAsync((Guid)input.PersonId.Value);
            booking.Vehicle = await _vehicleRepository.GetAsync((Guid)input.VehicleId.Value);
            var response = await _repository.InsertAsync(booking);

            await CurrentUnitOfWork.SaveChangesAsync();
            
            var result = ObjectMapper.Map<BookingDto>(response);


            foreach (var additionalDriverId in input.AdditionalDriverIds)
            {
                var additionalDriver = new AdditionalDriver
                {
                    Booking = await _repository.GetAsync((Guid)result.Id),
                    Person = await _personRepository.GetAsync((Guid)additionalDriverId.Value)
                };
                await _additionalDriverRepository.InsertAsync(additionalDriver);
                await CurrentUnitOfWork.SaveChangesAsync();
            }


            foreach(var rentalAddonId in input.RentalAddonIds)
            {
                var rentalAddon = new BookedRentalAddon
                {
                    Booking = await _repository.GetAsync((Guid)response.Id),
                    RentalAddon = await _rentalAddonRepository.GetAsync((Guid)rentalAddonId.Value)
                };
                await _bookedRentalAddonRepository.InsertAsync(rentalAddon);
                await CurrentUnitOfWork.SaveChangesAsync();
            }

            return result;

        }

        [HttpGet]
        public async Task<BookingDto> GetAsync(Guid id)
        {
            return ObjectMapper.Map<BookingDto>(await _repository.GetAllIncluding(x => x.Person, y => y.Vehicle).FirstOrDefaultAsync());
        }

        [HttpGet]
        public async Task<List<BookingDto>> GetAllAsync()
        {
            return ObjectMapper.Map<List<BookingDto>>(_repository.GetAllIncluding(a => a.Person, b => b.Vehicle));
        }

        [HttpPatch]
        public async Task<BookingDto> UpdateAsync(BookingDto input)
        {
            var booking = await _repository.GetAllIncluding(x => x.Person, y => y.Vehicle).FirstOrDefaultAsync();
            booking = ObjectMapper.Map(input, booking);
            booking.Person = input.PersonId != null ? await _personRepository.GetAsync((Guid)input.PersonId.Value) : booking.Person;
            booking.Vehicle = input.VehicleId != null ? await _vehicleRepository.GetAsync((Guid)input.VehicleId.Value) : booking.Vehicle;
            
            
            var response = await _repository.UpdateAsync(booking);
            await CurrentUnitOfWork.SaveChangesAsync();
            return ObjectMapper.Map<BookingDto>(response);
        }

        [HttpDelete]
        public async Task DeleteAsync(Guid id)
        {
            await _repository.DeleteAsync(id);
        }
    }
}
