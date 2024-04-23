using AutoMapper;
using VehicleBookingRentalApp.Authorization.Users;
using VehicleBookingRentalApp.Domain;
using VehicleBookingRentalApp.Services.Persons.Dto;

namespace VehicleBookingRentalApp.Services.Persons
{
    public class PersonMappingProfile :Profile
    {
        public PersonMappingProfile()
        {
            CreateMap<CreatePersonDto, User>()
                .ForMember(e => e.EmailAddress, m => m.MapFrom(x => x.Email))
                .ForMember(e => e.Name, m => m.MapFrom(x => x.Name))
                .ForMember(e => e.Password, m => m.MapFrom(x => x.Password))
                .ForMember(e => e.Surname, m => m.MapFrom(x => x.Surname))
                .ForMember(e => e.UserName, m => m.MapFrom(x => x.Email))
                .ForMember(user => user.Id, e => e.Ignore());

            CreateMap<Person, PersonDto>()
                .ForMember(x => x.UserId, m => m.MapFrom(x => x.User != null ? x.User.Id : (long?)null))
                .ForMember(x => x.Name, m => m.MapFrom(x => x.Name))
                .ForMember(x => x.Surname, m => m.MapFrom(x => x.Surname))
                .ForMember(x => x.FullName, m => m.MapFrom(x => x.Name + " " + x.Surname))
                .ForMember(x => x.Gender, m => m.MapFrom(x => x.Gender))
                .ForMember(x => x.DOB, m => m.MapFrom(x => x.DOB))
                .ForMember(x => x.IDNumber, m => m.MapFrom(x => x.IDNumber))
                .ForMember(x => x.Email, m => m.MapFrom(x => x.Email))
                .ForMember(x => x.ContactNumber, m => m.MapFrom(x => x.ContactNumber))
                .ForMember(x => x.Address, m => m.MapFrom(x => x.Address));


            CreateMap<CreatePersonDto, Person>()
                .ForMember(x => x.Name, m => m.MapFrom(x => x.Name))
                .ForMember(x => x.Surname, m => m.MapFrom(x => x.Surname))
                .ForMember(x => x.Gender, m => m.MapFrom(x => x.Gender))
                .ForMember(x => x.DOB, m => m.MapFrom(x => x.DOB))
                .ForMember(x => x.IDNumber, m => m.MapFrom(x => x.IDNumber))
                .ForMember(x => x.Email, m => m.MapFrom(x => x.Email))
                .ForMember(x => x.ContactNumber, m => m.MapFrom(x => x.ContactNumber))
                .ForMember(x => x.Address, m => m.MapFrom(x => x.Address));



            CreateMap<PersonDto, Person>()
               .ForMember(e => e.Id, d => d.Ignore());
        }
    }
}
