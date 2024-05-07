using System;

namespace VehicleBookingRentalApp.Services.Utils
{
    public static class CalculateRentalPeriod
    {
        public static int CalculateDays(DateTime startDate, DateTime endDate)
        {
            return (endDate - startDate).Days;
        }
    }
}
