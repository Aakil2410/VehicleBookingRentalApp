using Abp.Application.Services;
using Abp.Application.Services.Dto;
using System;
using VehicleBookingRentalApp.Services.Documents.Dto;
using VehicleBookingRentalApp.Services.RentalAddons.Dto;

namespace VehicleBookingRentalApp.Services.Documents
{
    public interface IDocumentAppService : IAsyncCrudAppService<DocumentDto, Guid, PagedAndSortedResultRequestDto>
    {

    }
}
