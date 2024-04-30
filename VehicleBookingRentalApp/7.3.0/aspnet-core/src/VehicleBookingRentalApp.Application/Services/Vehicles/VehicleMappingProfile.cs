using AutoMapper;
using VehicleBookingRentalApp.Domain;
using VehicleBookingRentalApp.Services.Utils;
using VehicleBookingRentalApp.Services.Vehicles.Dto;

namespace VehicleBookingRentalApp.Services.Vehicles
{
    public class VehicleMappingProfile : Profile
    {
        public VehicleMappingProfile()
        {
            CreateMap<Vehicle, VehicleDto>();

            CreateMap<VehicleDto, Vehicle>()
                .ForMember(e => e.Id, d => d.Ignore());
        }
    }
}
