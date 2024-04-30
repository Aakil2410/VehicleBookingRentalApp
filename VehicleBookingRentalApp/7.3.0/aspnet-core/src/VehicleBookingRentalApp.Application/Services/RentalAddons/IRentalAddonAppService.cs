using Abp.Application.Services.Dto;
using Abp.Application.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VehicleBookingRentalApp.Services.RentalAddons.Dto;

namespace VehicleBookingRentalApp.Services.RentalAddons
{
    public interface IRentalAddonAppService : IAsyncCrudAppService<RentalAddonDto, Guid, PagedAndSortedResultRequestDto>
    {

    }
}
