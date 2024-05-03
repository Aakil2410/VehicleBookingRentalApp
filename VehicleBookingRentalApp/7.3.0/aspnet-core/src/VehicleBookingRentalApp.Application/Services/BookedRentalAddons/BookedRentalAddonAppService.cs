using Abp.Application.Services;
using Abp.Domain.Repositories;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using VehicleBookingRentalApp.Domain;
using VehicleBookingRentalApp.Services.AdditionalDrivers.Dto;
using VehicleBookingRentalApp.Services.BookedRentalAddons.Dto;

namespace VehicleBookingRentalApp.Services.BookedRentalAddons
{
    public class BookedRentalAddonAppService : ApplicationService, IBookedRentalAddonAppService
    {
        private readonly IRepository<BookedRentalAddon, Guid> _repository;
        private readonly IRepository<RentalAddon, Guid> _rentalAddonRepository;
        private readonly IRepository<Booking, Guid> _bookingRepository;

        public BookedRentalAddonAppService(IRepository<BookedRentalAddon, Guid> repository,
                                           IRepository<RentalAddon, Guid> rentalAddonRepository,
                                           IRepository<Booking, Guid> bookingRepository)
        {
            _repository = repository;
            _rentalAddonRepository = rentalAddonRepository;
            _bookingRepository = bookingRepository;
        }

        [HttpPost]
        public async Task<BookedRentalAddonDto> CreateAsync(BookedRentalAddonDto input)
        {
            var rentalAddon = ObjectMapper.Map<BookedRentalAddon>(input);
            rentalAddon.Booking = await _bookingRepository.GetAsync((Guid)input.BookingId.Value);
            rentalAddon.RentalAddon = await _rentalAddonRepository.GetAsync((Guid)input.RentalAddonId.Value);
            var response = await _repository.InsertAsync(rentalAddon);
            await CurrentUnitOfWork.SaveChangesAsync();
            return ObjectMapper.Map<BookedRentalAddonDto>(response);
        }

        [HttpGet]
        public async Task<BookedRentalAddonDto> GetAsync(Guid id)
        {
            return ObjectMapper.Map<BookedRentalAddonDto>(await _repository.GetAllIncluding(x => x.Booking, y => y.RentalAddon).FirstOrDefaultAsync());
        }

        public async Task<List<BookedRentalAddonDto>> GetAllAsync()
        {
            return ObjectMapper.Map<List<BookedRentalAddonDto>>(_repository.GetAllIncluding(x => x.Booking, y => y.RentalAddon));
        }

        public async Task<BookedRentalAddonDto> UpdateAsync(BookedRentalAddonDto input)
        {
            var rentalAddon = await _repository.GetAllIncluding(x => x.Booking, y => y.RentalAddon).FirstOrDefaultAsync();
            rentalAddon = ObjectMapper.Map(input, rentalAddon);
            rentalAddon.RentalAddon = input.RentalAddonId != null ? await _rentalAddonRepository.GetAsync((Guid)input.RentalAddonId) : rentalAddon.RentalAddon;
            rentalAddon.Booking = input.BookingId != null ? await _bookingRepository.GetAsync((Guid)input.BookingId.Value) : rentalAddon.Booking;
            var response = await _repository.UpdateAsync(rentalAddon);
            await CurrentUnitOfWork.SaveChangesAsync();
            return ObjectMapper.Map<BookedRentalAddonDto>(response);
        }

        public async Task DeleteAsync(Guid id)
        {
            await _repository.DeleteAsync(id);
        }
    }
}
