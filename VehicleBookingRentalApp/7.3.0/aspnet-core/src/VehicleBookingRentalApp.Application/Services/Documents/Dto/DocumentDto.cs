using Abp.Application.Services.Dto;
using System;

namespace VehicleBookingRentalApp.Services.Documents.Dto
{
    public class DocumentDto : EntityDto<Guid>
    {
        public string DocumentName { get; set; }

        //public virtual bool? Valid { get; set; }

        public Guid? PersonId { get; set; }

        public Guid? AdditionalDriverId { get; set; }

        public Guid? BookingId { get; set; }

    }
}
