﻿using Abp.EntityFrameworkCore.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using Abp.Zero.EntityFrameworkCore;
using VehicleBookingRentalApp.EntityFrameworkCore.Seed;

namespace VehicleBookingRentalApp.EntityFrameworkCore
{
    [DependsOn(
        typeof(VehicleBookingRentalAppCoreModule), 
        typeof(AbpZeroCoreEntityFrameworkCoreModule))]
    public class VehicleBookingRentalAppEntityFrameworkModule : AbpModule
    {
        /* Used it tests to skip dbcontext registration, in order to use in-memory database of EF Core */
        public bool SkipDbContextRegistration { get; set; }

        public bool SkipDbSeed { get; set; }

        public override void PreInitialize()
        {
            if (!SkipDbContextRegistration)
            {
                Configuration.Modules.AbpEfCore().AddDbContext<VehicleBookingRentalAppDbContext>(options =>
                {
                    if (options.ExistingConnection != null)
                    {
                        VehicleBookingRentalAppDbContextConfigurer.Configure(options.DbContextOptions, options.ExistingConnection);
                    }
                    else
                    {
                        VehicleBookingRentalAppDbContextConfigurer.Configure(options.DbContextOptions, options.ConnectionString);
                    }
                });
            }
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(VehicleBookingRentalAppEntityFrameworkModule).GetAssembly());
        }

        public override void PostInitialize()
        {
            if (!SkipDbSeed)
            {
                SeedHelper.SeedHostDb(IocManager);
            }
        }
    }
}
