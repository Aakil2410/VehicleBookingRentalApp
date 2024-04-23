using VehicleBookingRentalApp.Debugging;

namespace VehicleBookingRentalApp
{
    public class VehicleBookingRentalAppConsts
    {
        public const string LocalizationSourceName = "VehicleBookingRentalApp";

        public const string ConnectionStringName = "Default";

        public const bool MultiTenancyEnabled = true;


        /// <summary>
        /// Default pass phrase for SimpleStringCipher decrypt/encrypt operations
        /// </summary>
        public static readonly string DefaultPassPhrase =
            DebugHelper.IsDebug ? "gsKxGZ012HLL3MI5" : "a31a9b31953642bdb21e7d9fdb92e0e8";
    }
}
