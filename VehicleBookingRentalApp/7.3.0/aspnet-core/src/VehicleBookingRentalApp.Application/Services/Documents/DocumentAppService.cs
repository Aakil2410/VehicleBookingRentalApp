using Abp.Application.Services;
using Abp.Application.Services.Dto;
using Abp.Domain.Repositories;
using System;
using VehicleBookingRentalApp.Domain;
using VehicleBookingRentalApp.Services.Documents.Dto;

namespace VehicleBookingRentalApp.Services.Documents
{
    public class DocumentAppService : AsyncCrudAppService<Document, DocumentDto, Guid, PagedAndSortedResultRequestDto>, IDocumentAppService
    {
        private readonly IRepository<Document, Guid> _repository;

        public DocumentAppService(IRepository<Document, Guid> repository) : base(repository)
        {
            _repository = repository;
        }
    }
}
