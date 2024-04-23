using System.Threading.Tasks;
using Abp.Application.Services;
using VehicleBookingRentalApp.Authorization.Accounts.Dto;

namespace VehicleBookingRentalApp.Authorization.Accounts
{
    public interface IAccountAppService : IApplicationService
    {
        Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

        Task<RegisterOutput> Register(RegisterInput input);
    }
}
