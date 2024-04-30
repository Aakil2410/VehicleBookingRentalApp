using Abp.Application.Services;
using Abp.Application.Services.Dto;
using Abp.Domain.Repositories;
using System;
using VehicleBookingRentalApp.Domain;
using VehicleBookingRentalApp.Services.RentalAddons.Dto;

namespace VehicleBookingRentalApp.Services.RentalAddons
{
    public class RentalAddonAppService : AsyncCrudAppService<RentalAddon, RentalAddonDto, Guid, PagedAndSortedResultRequestDto>, IRentalAddonAppService
    {
        private readonly IRepository<RentalAddon, Guid> _repository;

        public RentalAddonAppService(IRepository<RentalAddon, Guid> repository) : base(repository)
        {
            _repository = repository;
        }
    }
}
