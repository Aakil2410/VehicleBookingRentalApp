using Abp.Zero.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using VehicleBookingRentalApp.Domain;
using VehicleBookingRentalApp.MultiTenancy;
using VehicleBookingRentalApp.Authorization.Roles;
using VehicleBookingRentalApp.Authorization.Users;

namespace VehicleBookingRentalApp.EntityFrameworkCore
{
    public class VehicleBookingRentalAppDbContext : AbpZeroDbContext<Tenant, Role, User, VehicleBookingRentalAppDbContext>
    {
        /* Define a DbSet for each entity of the application */

        public DbSet<AdditionalDriver> AdditionalDrivers {  get; set; }

        public DbSet<BookedRentalAddon> BookedRentalAddons { get; set; }

        public DbSet<Booking> Bookings { get; set; }

        public DbSet<Document> Documents { get; set; }

        public DbSet<Person> Persons { get; set; }

        public DbSet<RentalAddon> RentalAddons { get; set; }

        public DbSet<Transaction> Transactions { get; set; }

        public DbSet<Vehicle> Vehicles { get; set; }

        public VehicleBookingRentalAppDbContext(DbContextOptions<VehicleBookingRentalAppDbContext> options)
            : base(options)
        {
        }
    }
}
