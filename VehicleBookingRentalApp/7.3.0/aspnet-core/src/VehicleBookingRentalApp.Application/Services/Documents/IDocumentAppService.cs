using Abp.Application.Services;
using System.Collections.Generic;
using System.Threading.Tasks;
using System;
using VehicleBookingRentalApp.Services.Vehicles.Dto;
using VehicleBookingRentalApp.Services.Documents.Dto;

namespace VehicleBookingRentalApp.Services.Documents
{
    public interface IDocumentAppService : IApplicationService
    {
        Task<DocumentDto> CreateAsync(DocumentDto input);

        Task<DocumentDto> GetAsync(Guid id);

        Task<List<DocumentDto>> GetAllAsync();

        Task<DocumentDto> UpdateAsync(DocumentDto input);

        Task DeleteAsync(Guid id);
    }
}
