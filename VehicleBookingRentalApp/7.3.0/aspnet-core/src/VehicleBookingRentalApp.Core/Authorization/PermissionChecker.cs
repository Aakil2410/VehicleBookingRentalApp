using Abp.Authorization;
using VehicleBookingRentalApp.Authorization.Roles;
using VehicleBookingRentalApp.Authorization.Users;

namespace VehicleBookingRentalApp.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
