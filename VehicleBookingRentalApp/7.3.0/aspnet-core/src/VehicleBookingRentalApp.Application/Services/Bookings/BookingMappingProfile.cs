using Abp.Threading.Extensions;
using AutoMapper;
using System;
using VehicleBookingRentalApp.Domain;
using VehicleBookingRentalApp.Services.Bookings.Dto;
using VehicleBookingRentalApp.Services.Utils;

namespace VehicleBookingRentalApp.Services.Bookings
{
    public class BookingMappingProfile : Profile
    {
        public BookingMappingProfile()
        {
            CreateMap<Booking, BookingDto>()
                .ForMember(e => e.PersonId, m => m.MapFrom(e => e.Person != null ? e.Person.Id : (Guid?)null))
                .ForMember(e => e.VehicleId, m => m.MapFrom(e => e.Vehicle != null ? e.Vehicle.Id : (Guid?)null))
                //.ForMember(x => x.RentalPeriod, m => m.MapFrom(x => x.StartDate - x.EndDate))
                .ForMember(x => x.CollectionTypeName, m => m.MapFrom(x => x.CollectionType != null ? x.CollectionType.GetEnumDescription() : null))
                .ForMember(x => x.StatusName, m => m.MapFrom(x => x.BookingStatus != null ? x.BookingStatus.GetEnumDescription() : null));


            CreateMap<BookingDto, Booking>()
                .ForMember(e => e.Id, d => d.Ignore())
                .ForMember(e => e.Person, d => d.Ignore())
                .ForMember(e => e.Vehicle, d => d.Ignore());
        }
    }
}
