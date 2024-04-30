using AutoMapper;
using System;
using VehicleBookingRentalApp.Services.Documents.Dto;
using Document = VehicleBookingRentalApp.Domain.Document;

namespace VehicleBookingRentalApp.Services.Documents
{
    public class DocumentMappingProfile : Profile
    {
        public DocumentMappingProfile()
        {
            CreateMap<Document, DocumentDto>()
                .ForMember(e => e.PersonId, m => m.MapFrom(e => e.Person != null ? e.Person.Id : (Guid?)null))
                .ForMember(e => e.AdditionalDriverId, m => m.MapFrom(e => e.AdditionalDriver != null ? e.AdditionalDriver.Id : (Guid?)null))
                .ForMember(e => e.BookingId, m => m.MapFrom(e => e.Booking != null ? e.Booking.Id : (Guid?)null));

            CreateMap<DocumentDto, Document>()
                .ForMember(e => e.Id, d => d.Ignore())
                .ForMember(e => e.Person, d => d.Ignore())
                .ForMember(e => e.AdditionalDriver, d => d.Ignore())
                .ForMember(e => e.Booking, d => d.Ignore());
        }
    }
}
