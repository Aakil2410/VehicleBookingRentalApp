using Microsoft.Extensions.Configuration;
using Castle.MicroKernel.Registration;
using Abp.Events.Bus;
using Abp.Modules;
using Abp.Reflection.Extensions;
using VehicleBookingRentalApp.Configuration;
using VehicleBookingRentalApp.EntityFrameworkCore;
using VehicleBookingRentalApp.Migrator.DependencyInjection;

namespace VehicleBookingRentalApp.Migrator
{
    [DependsOn(typeof(VehicleBookingRentalAppEntityFrameworkModule))]
    public class VehicleBookingRentalAppMigratorModule : AbpModule
    {
        private readonly IConfigurationRoot _appConfiguration;

        public VehicleBookingRentalAppMigratorModule(VehicleBookingRentalAppEntityFrameworkModule abpProjectNameEntityFrameworkModule)
        {
            abpProjectNameEntityFrameworkModule.SkipDbSeed = true;

            _appConfiguration = AppConfigurations.Get(
                typeof(VehicleBookingRentalAppMigratorModule).GetAssembly().GetDirectoryPathOrNull()
            );
        }

        public override void PreInitialize()
        {
            Configuration.DefaultNameOrConnectionString = _appConfiguration.GetConnectionString(
                VehicleBookingRentalAppConsts.ConnectionStringName
            );

            Configuration.BackgroundJobs.IsJobExecutionEnabled = false;
            Configuration.ReplaceService(
                typeof(IEventBus), 
                () => IocManager.IocContainer.Register(
                    Component.For<IEventBus>().Instance(NullEventBus.Instance)
                )
            );
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(VehicleBookingRentalAppMigratorModule).GetAssembly());
            ServiceCollectionRegistrar.Register(IocManager);
        }
    }
}
