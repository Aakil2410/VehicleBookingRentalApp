﻿using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using VehicleBookingRentalApp.Configuration;

namespace VehicleBookingRentalApp.Web.Host.Startup
{
    [DependsOn(
       typeof(VehicleBookingRentalAppWebCoreModule))]
    public class VehicleBookingRentalAppWebHostModule: AbpModule
    {
        private readonly IWebHostEnvironment _env;
        private readonly IConfigurationRoot _appConfiguration;

        public VehicleBookingRentalAppWebHostModule(IWebHostEnvironment env)
        {
            _env = env;
            _appConfiguration = env.GetAppConfiguration();
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(VehicleBookingRentalAppWebHostModule).GetAssembly());
        }
    }
}
