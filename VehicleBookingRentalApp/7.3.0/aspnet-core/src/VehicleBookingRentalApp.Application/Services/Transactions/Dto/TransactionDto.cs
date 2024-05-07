using Abp.Application.Services.Dto;
using System;
using VehicleBookingRentalApp.Domain.Enums;
using VehicleBookingRentalApp.Domain;

namespace VehicleBookingRentalApp.Services.Transactions.Dto
{
    public class TransactionDto : EntityDto<Guid>
    {
        public TransactionType? TransactionType { get; set; }

        public string TransactionTypeName { get; set; }

        public decimal? Amount { get; set; }

        public PaymentStatus? PaymentStatus { get; set; }

        public string StatusName { get; set; }

        public Guid? PersonId { get; set; }

        public Guid? BookingId { get; set; }
    }
}
