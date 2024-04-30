using Abp.Application.Services.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VehicleBookingRentalApp.Domain.Enums;

namespace VehicleBookingRentalApp.Services.Vehicles.Dto
{
    public class VehicleDto : EntityDto<Guid>
    {
        public string Class { get; set; }

        public string Make { get; set; }

        public string Model { get; set; }

        public string Year { get; set; }

        public string VIN { get; set; }

        public string LicensePlateNumber { get; set; }

        public int Mileage { get; set; } // string??

        public string FuelType { get; set; }

        public string Color { get; set; }

        public decimal? BaseRentalPrice { get; set; }

        public VehicleStatus? VehicleStatus { get; set; }

        public string StatusName { get; set; }

        // current location

        // location history

        // gps table????
    }
}
