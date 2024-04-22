using Abp.MultiTenancy;
using VehicleBookingRentalApp.Authorization.Users;

namespace VehicleBookingRentalApp.MultiTenancy
{
    public class Tenant : AbpTenant<User>
    {
        public Tenant()
        {            
        }

        public Tenant(string tenancyName, string name)
            : base(tenancyName, name)
        {
        }
    }
}
