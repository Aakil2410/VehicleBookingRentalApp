using Abp.Application.Services;
using Abp.Domain.Repositories;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using VehicleBookingRentalApp.Domain;
using VehicleBookingRentalApp.Services.Documents.Dto;

namespace VehicleBookingRentalApp.Services.Documents
{
    public class DocumentAppService : ApplicationService, IDocumentAppService
    {
        private readonly IRepository<Document, Guid> _repository;
        private readonly IRepository<Person, Guid> _personRepository;
        private readonly IRepository<AdditionalDriver, Guid> _additionalDriverRepository;
        private readonly IRepository<Booking, Guid> _bookingRepository;


        public DocumentAppService(IRepository<Document, Guid> repository,
                                  IRepository<Person, Guid> personRepository,
                                  IRepository<AdditionalDriver, Guid> additionalDriverRepository,
                                  IRepository<Booking, Guid> bookingRepository)
        {
            _repository = repository;
            _personRepository = personRepository;
            _additionalDriverRepository = additionalDriverRepository;
            _bookingRepository = bookingRepository;
        }

        [HttpPost]
        public async Task<DocumentDto> CreateAsync(DocumentDto input)
        {
            var document = ObjectMapper.Map<Document>(input);
            document.Person = await _personRepository.GetAsync((Guid)input.PersonId.Value);
            document.AdditionalDriver = await _additionalDriverRepository.GetAsync((Guid)input.AdditionalDriverId.Value);
            document.Booking = await _bookingRepository.GetAsync((Guid)input.BookingId.Value);
            document = await _repository.InsertAsync(document);
            await CurrentUnitOfWork.SaveChangesAsync();
            return ObjectMapper.Map<DocumentDto>(document);
        }

        [HttpGet]
        public async Task<DocumentDto> GetAsync(Guid id)
        {
            return ObjectMapper.Map<DocumentDto>(await _repository.GetAllIncluding(x => x.Person, y => y.AdditionalDriver, z =>z.Booking).FirstOrDefaultAsync());
        }

        [HttpGet]
        public async Task<List<DocumentDto>> GetAllAsync()
        {

            return ObjectMapper.Map<List<DocumentDto>>(_repository.GetAllIncluding(x => x.Person, y => y.AdditionalDriver, z => z.Booking));
        }

        [HttpPatch]
        public async Task<DocumentDto> UpdateAsync(DocumentDto input)
        {
            var document = await _repository.GetAllIncluding(x => x.Person, y => y.AdditionalDriver).FirstOrDefaultAsync();
            ObjectMapper.Map(input, document);
            document.Person = input?.PersonId != null ? await _personRepository.GetAsync((Guid)input.PersonId) : document.Person;
            document.AdditionalDriver = input?.AdditionalDriverId != null ? await _additionalDriverRepository.GetAsync((Guid)input.AdditionalDriverId) : document.AdditionalDriver;
            document.Booking = input?.BookingId != null ? await _bookingRepository.GetAsync((Guid)input.BookingId) : document.Booking;
            var response = await _repository.UpdateAsync(document);
            await CurrentUnitOfWork.SaveChangesAsync();
            return ObjectMapper.Map<DocumentDto>(response);
        }

        public async Task DeleteAsync(Guid id)
        {
            await _repository.DeleteAsync(id);
        }
    }
}
