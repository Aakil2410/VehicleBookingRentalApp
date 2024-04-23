using Abp.Application.Services.Dto;

namespace VehicleBookingRentalApp.Roles.Dto
{
    public class PagedRoleResultRequestDto : PagedResultRequestDto
    {
        public string Keyword { get; set; }
    }
}

