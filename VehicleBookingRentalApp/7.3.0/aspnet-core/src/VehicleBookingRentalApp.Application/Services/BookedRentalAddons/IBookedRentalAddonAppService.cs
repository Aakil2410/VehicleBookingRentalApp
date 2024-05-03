using Abp.Application.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VehicleBookingRentalApp.Services.AdditionalDrivers.Dto;
using VehicleBookingRentalApp.Services.BookedRentalAddons.Dto;

namespace VehicleBookingRentalApp.Services.BookedRentalAddons
{
    public interface IBookedRentalAddonAppService : IApplicationService
    {
        Task<BookedRentalAddonDto> CreateAsync(BookedRentalAddonDto input);

        Task<BookedRentalAddonDto> GetAsync(Guid id);

        Task<List<BookedRentalAddonDto>> GetAllAsync();

        Task<BookedRentalAddonDto> UpdateAsync(BookedRentalAddonDto input);

        Task DeleteAsync(Guid id);
    }
}
