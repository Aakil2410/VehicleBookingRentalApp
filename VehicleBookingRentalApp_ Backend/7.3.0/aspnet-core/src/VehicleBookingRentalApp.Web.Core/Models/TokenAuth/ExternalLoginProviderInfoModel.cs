using Abp.AutoMapper;
using VehicleBookingRentalApp.Authentication.External;

namespace VehicleBookingRentalApp.Models.TokenAuth
{
    [AutoMapFrom(typeof(ExternalLoginProviderInfo))]
    public class ExternalLoginProviderInfoModel
    {
        public string Name { get; set; }

        public string ClientId { get; set; }
    }
}
