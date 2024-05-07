using Abp.Domain.Entities;
using Microsoft.AspNetCore.Http;
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace VehicleBookingRentalApp.Domain
{
    public class Document : Entity<Guid>
    {
        [NotMapped]

        public virtual IFormFile? DocumentFile { get; set;  }

        public virtual string DocumentName { get; set; }

        public virtual Person Person { get; set; }

        public virtual Booking Booking { get; set; }
    }
}
