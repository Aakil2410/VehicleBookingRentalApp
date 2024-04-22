using Abp.AspNetCore;
using Abp.AspNetCore.TestBase;
using Abp.Modules;
using Abp.Reflection.Extensions;
using VehicleBookingRentalApp.EntityFrameworkCore;
using VehicleBookingRentalApp.Web.Startup;
using Microsoft.AspNetCore.Mvc.ApplicationParts;

namespace VehicleBookingRentalApp.Web.Tests
{
    [DependsOn(
        typeof(VehicleBookingRentalAppWebMvcModule),
        typeof(AbpAspNetCoreTestBaseModule)
    )]
    public class VehicleBookingRentalAppWebTestModule : AbpModule
    {
        public VehicleBookingRentalAppWebTestModule(VehicleBookingRentalAppEntityFrameworkModule abpProjectNameEntityFrameworkModule)
        {
            abpProjectNameEntityFrameworkModule.SkipDbContextRegistration = true;
        } 
        
        public override void PreInitialize()
        {
            Configuration.UnitOfWork.IsTransactional = false; //EF Core InMemory DB does not support transactions.
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(VehicleBookingRentalAppWebTestModule).GetAssembly());
        }
        
        public override void PostInitialize()
        {
            IocManager.Resolve<ApplicationPartManager>()
                .AddApplicationPartsIfNotAddedBefore(typeof(VehicleBookingRentalAppWebMvcModule).Assembly);
        }
    }
}