using System.Threading.Tasks;
using Abp.Application.Services;
using VehicleBookingRentalApp.Sessions.Dto;

namespace VehicleBookingRentalApp.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
