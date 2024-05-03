using Abp.Application.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VehicleBookingRentalApp.Services.Bookings.Dto;
using VehicleBookingRentalApp.Services.Persons.Dto;

namespace VehicleBookingRentalApp.Services.Bookings
{
    public interface IBookingAppService : IApplicationService
    {
        Task<BookingDto> CreateAsync(BookingDto input);

        Task<BookingDto> GetAsync(Guid id);

        Task<List<BookingDto>> GetAllAsync();

        Task<BookingDto> UpdateAsync(BookingDto input);

        Task DeleteAsync(Guid id);
    }
}
