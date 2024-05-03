using AutoMapper;
using System;
using VehicleBookingRentalApp.Domain;
using VehicleBookingRentalApp.Services.AdditionalDrivers.Dto;
using VehicleBookingRentalApp.Services.Bookings.Dto;
using VehicleBookingRentalApp.Services.Utils;

namespace VehicleBookingRentalApp.Services.AdditionalDrivers
{
    public class AdditionalDriverMappingProfile : Profile
    {
        public AdditionalDriverMappingProfile()
        {
            CreateMap<AdditionalDriver, AdditionalDriverDto>()
                .ForMember(e => e.PersonId, m => m.MapFrom(e => e.Person != null ? e.Person.Id : (Guid?)null))
                .ForMember(e => e.BookingId, m => m.MapFrom(e => e.Booking != null ? e.Booking.Id : (Guid?)null));


            CreateMap<AdditionalDriverDto, AdditionalDriver>()
                .ForMember(e => e.Id, d => d.Ignore())
                .ForMember(e => e.Person, d => d.Ignore())
                .ForMember(e => e.Booking, d => d.Ignore());

        }
    }
}
