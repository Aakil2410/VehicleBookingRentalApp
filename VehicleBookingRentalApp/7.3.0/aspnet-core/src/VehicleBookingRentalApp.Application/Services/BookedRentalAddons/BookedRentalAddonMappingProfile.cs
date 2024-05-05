using AutoMapper;
using System;
using VehicleBookingRentalApp.Domain;
using VehicleBookingRentalApp.Services.BookedRentalAddons.Dto;

namespace VehicleBookingRentalApp.Services.BookedRentalAddons
{
    public class BookedRentalAddonMappingProfile : Profile
    {
        public BookedRentalAddonMappingProfile()
        {
            CreateMap<BookedRentalAddon, BookedRentalAddonDto>()
                .ForMember(e => e.RentalAddonId, m => m.MapFrom(e => e.RentalAddon != null ? e.RentalAddon.Id : (Guid?)null))
                .ForMember(e => e.BookingId, m => m.MapFrom(e => e.Booking != null ? e.Booking.Id : (Guid?)null));


            CreateMap<BookedRentalAddonDto, BookedRentalAddon>()
                .ForMember(e => e.Id, d => d.Ignore())
                .ForMember(e => e.RentalAddon, d => d.Ignore())
                .ForMember(e => e.Booking, d => d.Ignore());
        }
    }
}
