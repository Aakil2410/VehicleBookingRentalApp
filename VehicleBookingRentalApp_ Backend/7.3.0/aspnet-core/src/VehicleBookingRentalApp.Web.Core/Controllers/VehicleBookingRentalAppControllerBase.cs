using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace VehicleBookingRentalApp.Controllers
{
    public abstract class VehicleBookingRentalAppControllerBase: AbpController
    {
        protected VehicleBookingRentalAppControllerBase()
        {
            LocalizationSourceName = VehicleBookingRentalAppConsts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}
