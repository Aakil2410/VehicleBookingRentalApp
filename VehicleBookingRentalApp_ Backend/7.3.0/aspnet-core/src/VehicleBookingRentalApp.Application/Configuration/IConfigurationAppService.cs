using System.Threading.Tasks;
using VehicleBookingRentalApp.Configuration.Dto;

namespace VehicleBookingRentalApp.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
