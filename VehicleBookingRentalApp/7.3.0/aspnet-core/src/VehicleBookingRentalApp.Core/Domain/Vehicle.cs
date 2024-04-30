using Abp.Domain.Entities.Auditing;
using System;
using VehicleBookingRentalApp.Domain.Enums;

namespace VehicleBookingRentalApp.Domain
{
    public class Vehicle : FullAuditedEntity<Guid>
    {
        public virtual string Class {  get; set; }

        public virtual string Make {  get; set; }

        public virtual string Model { get; set; }

        public virtual string Year { get; set; }

        public virtual string VIN { get; set; }

        public virtual string LicensePlateNumber { get; set; }

        public virtual int Mileage { get; set; } // string??

        public virtual string FuelType { get; set; }

        public virtual string Color { get; set; }

        public virtual decimal? BaseRentalPrice { get; set; }

        public virtual VehicleStatus? VehicleStatus { get; set; }

        public virtual string AdditionalDetails { get; set; }

        // current location

        // location history

        // gps table????

    }
}
