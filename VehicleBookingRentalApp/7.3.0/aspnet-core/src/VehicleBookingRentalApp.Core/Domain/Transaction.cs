using Abp.Domain.Entities.Auditing;
using System;
using VehicleBookingRentalApp.Domain.Enums;

namespace VehicleBookingRentalApp.Domain
{
    public class Transaction : FullAuditedEntity<Guid>
    {
        public virtual TransactionType? TransactionType { get; set; }

        public virtual decimal? Amount { get; set; }

        public virtual PaymentStatus? PaymentStatus { get; set; }

        public virtual Person Person { get; set; }

        public virtual Booking Booking { get; set; }

    }
}
