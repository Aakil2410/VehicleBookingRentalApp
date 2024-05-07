using Abp.Application.Services;
using Abp.Domain.Repositories;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using VehicleBookingRentalApp.Domain;
using VehicleBookingRentalApp.Services.Transactions.Dto;

namespace VehicleBookingRentalApp.Services.Transactions
{
    public class TransactionAppService : ApplicationService, ITransactionAppService
    {

        private readonly IRepository<Transaction, Guid> _repository;
        private readonly IRepository<Person, Guid> _personRepository;
        private readonly IRepository<Booking, Guid> _bookingRepository;

        public TransactionAppService(IRepository<Transaction, Guid> repository,
                                     IRepository<Person, Guid> personRepository,
                                     IRepository<Booking, Guid> bookingRepository)
        {
            this._repository = repository;
            this._personRepository = personRepository;
            this._bookingRepository = bookingRepository;
        }

        [HttpPost]
        public async Task<TransactionDto> CreateAsync(TransactionDto input)
        {
            var transact = ObjectMapper.Map<Transaction>(input);
            transact.Person = await _personRepository.GetAsync((Guid)input.PersonId.Value);
            transact.Booking = await _bookingRepository.GetAsync((Guid)input.BookingId.Value);
            var response = await _repository.InsertAsync(transact);
            await CurrentUnitOfWork.SaveChangesAsync();
            return ObjectMapper.Map<TransactionDto>(response);
        }

        [HttpGet]
        public async Task<TransactionDto> GetAsync(Guid id)
        {
            return ObjectMapper.Map<TransactionDto>(await _repository.GetAllIncluding(x => x.Booking, y => y.Person).FirstOrDefaultAsync());
        }

        [HttpGet]
        public async Task<List<TransactionDto>> GetAllAsync()
        {
            return ObjectMapper.Map<List<TransactionDto>>(_repository.GetAllIncluding(x => x.Booking, y => y.Person));
        }

        [HttpPatch]
        public async Task<TransactionDto> UpdateAsync(TransactionDto input)
        {
            var transact = await _repository.GetAllIncluding(x => x.Booking).FirstOrDefaultAsync();
            transact = ObjectMapper.Map(input, transact);
            transact.Person = input.PersonId != null ? await _personRepository.GetAsync((Guid)input.PersonId.Value) : transact.Person;
            transact.Booking = input.BookingId != null ? await _bookingRepository.GetAsync((Guid)input.BookingId.Value) : transact.Booking;
            var response = await _repository.UpdateAsync(transact);
            await CurrentUnitOfWork.SaveChangesAsync();
            return ObjectMapper.Map<TransactionDto>(response);
        }

        public async Task DeleteAsync(Guid id)
        {
            await _repository.DeleteAsync(id);
        }
    }
}
