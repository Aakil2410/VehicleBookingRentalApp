using Abp.Application.Services;
using VehicleBookingRentalApp.MultiTenancy.Dto;

namespace VehicleBookingRentalApp.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedTenantResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}

