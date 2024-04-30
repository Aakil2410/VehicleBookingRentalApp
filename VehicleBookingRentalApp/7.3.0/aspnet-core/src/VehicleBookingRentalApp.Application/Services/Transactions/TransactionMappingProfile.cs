using AutoMapper;
using System;
using VehicleBookingRentalApp.Domain;
using VehicleBookingRentalApp.Services.Transactions.Dto;
using VehicleBookingRentalApp.Services.Utils;

namespace VehicleBookingRentalApp.Services.Transactions
{
    public class TransactionMappingProfile : Profile
    {
        public TransactionMappingProfile()
        {
            CreateMap<Transaction, TransactionDto>()
                .ForMember(e => e.BookingId, m => m.MapFrom(e => e.Booking != null ? e.Booking.Id : (Guid?)null))
                .ForMember(x => x.TransactionTypeName, m => m.MapFrom(x => x.TransactionType != null ? x.TransactionType.GetEnumDescription() : null))
                .ForMember(x => x.StatusName, m => m.MapFrom(x => x.PaymentStatus != null ? x.PaymentStatus.GetEnumDescription() : null));

            CreateMap<TransactionDto, Transaction>()
                .ForMember(e => e.Id, d => d.Ignore())
                .ForMember(e => e.Booking, d => d.Ignore());
        }
    }
}
