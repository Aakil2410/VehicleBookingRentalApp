using Abp.Configuration.Startup;
using Abp.Localization.Dictionaries;
using Abp.Localization.Dictionaries.Xml;
using Abp.Reflection.Extensions;

namespace VehicleBookingRentalApp.Localization
{
    public static class VehicleBookingRentalAppLocalizationConfigurer
    {
        public static void Configure(ILocalizationConfiguration localizationConfiguration)
        {
            localizationConfiguration.Sources.Add(
                new DictionaryBasedLocalizationSource(VehicleBookingRentalAppConsts.LocalizationSourceName,
                    new XmlEmbeddedFileLocalizationDictionaryProvider(
                        typeof(VehicleBookingRentalAppLocalizationConfigurer).GetAssembly(),
                        "VehicleBookingRentalApp.Localization.SourceFiles"
                    )
                )
            );
        }
    }
}
