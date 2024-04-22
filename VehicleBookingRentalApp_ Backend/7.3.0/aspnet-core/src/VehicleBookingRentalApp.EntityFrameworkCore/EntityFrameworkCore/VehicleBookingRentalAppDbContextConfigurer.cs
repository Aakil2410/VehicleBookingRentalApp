using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace VehicleBookingRentalApp.EntityFrameworkCore
{
    public static class VehicleBookingRentalAppDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<VehicleBookingRentalAppDbContext> builder, string connectionString)
        {
            builder.UseSqlServer(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<VehicleBookingRentalAppDbContext> builder, DbConnection connection)
        {
            builder.UseSqlServer(connection);
        }
    }
}
