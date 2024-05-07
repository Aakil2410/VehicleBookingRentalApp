using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using Microsoft.AspNetCore.Http;
using System;
using VehicleBookingRentalApp.Domain;

namespace VehicleBookingRentalApp.Services.Documents.Dto
{
    [AutoMap(typeof(Document))]
    public class DocumentDto : EntityDto<Guid>
    {
        public IFormFile? DocumentFile { get; set; }

        public string DocumentName { get; set; }

        public Guid? PersonId { get; set; }

        public Guid? BookingId { get; set; }

    }
}
