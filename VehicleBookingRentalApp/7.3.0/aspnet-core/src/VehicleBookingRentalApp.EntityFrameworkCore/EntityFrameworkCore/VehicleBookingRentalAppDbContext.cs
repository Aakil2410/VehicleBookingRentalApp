using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using VehicleBookingRentalApp.Authorization.Roles;
using VehicleBookingRentalApp.Authorization.Users;
using VehicleBookingRentalApp.MultiTenancy;

namespace VehicleBookingRentalApp.EntityFrameworkCore
{
    public class VehicleBookingRentalAppDbContext : AbpZeroDbContext<Tenant, Role, User, VehicleBookingRentalAppDbContext>
    {
        /* Define a DbSet for each entity of the application */
        
        public VehicleBookingRentalAppDbContext(DbContextOptions<VehicleBookingRentalAppDbContext> options)
            : base(options)
        {
        }
    }
}
