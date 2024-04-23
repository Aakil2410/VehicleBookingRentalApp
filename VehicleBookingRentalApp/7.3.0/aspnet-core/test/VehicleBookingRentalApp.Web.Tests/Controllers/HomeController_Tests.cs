﻿using System.Threading.Tasks;
using VehicleBookingRentalApp.Models.TokenAuth;
using VehicleBookingRentalApp.Web.Controllers;
using Shouldly;
using Xunit;

namespace VehicleBookingRentalApp.Web.Tests.Controllers
{
    public class HomeController_Tests: VehicleBookingRentalAppWebTestBase
    {
        [Fact]
        public async Task Index_Test()
        {
            await AuthenticateAsync(null, new AuthenticateModel
            {
                UserNameOrEmailAddress = "admin",
                Password = "123qwe"
            });

            //Act
            var response = await GetResponseAsStringAsync(
                GetUrl<HomeController>(nameof(HomeController.Index))
            );

            //Assert
            response.ShouldNotBeNullOrEmpty();
        }
    }
}