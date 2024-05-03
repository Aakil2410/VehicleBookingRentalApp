using Abp.Application.Services;
using Abp.Domain.Repositories;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VehicleBookingRentalApp.Authorization.Roles;
using VehicleBookingRentalApp.Authorization.Users;
using VehicleBookingRentalApp.Domain;
using VehicleBookingRentalApp.Services.Persons.Dto;
using VehicleBookingRentalApp.Users;

namespace VehicleBookingRentalApp.Services.Persons
{
    public class PersonAppService : ApplicationService, IPersonAppService
    {
        private readonly IRepository<Person, Guid> _repository;
        private readonly UserAppService _userAppService;
        private readonly UserManager _userManager;
        private readonly RoleManager _roleManager;
        private const string CharSet = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789!@#$%^&*()_+";
        public PersonAppService(IRepository<Person, Guid> repository,
                                UserAppService userAppService,
                                UserManager userManager,
                                RoleManager roleManager)
        {
            _repository = repository;
            _userAppService = userAppService;
            _userManager = userManager;
            _roleManager = roleManager;
        }

        [HttpPost]
        public async Task<PersonDto> CreateAsync(CreatePersonDto input)
        {
            var person = ObjectMapper.Map<Person>(input);
            if(input.Password != null)
            {
                person.User = await CreateUserAsync(input);
            }
            person = await _repository.InsertAsync(person);
            await CurrentUnitOfWork.SaveChangesAsync();
            return ObjectMapper.Map<PersonDto>(person);
        }
            

        [HttpGet]
        public async Task<PersonDto> GetAsync(Guid id)
        {
            var person = _repository.GetAllIncluding(x => x.User).FirstOrDefault(x => x.Id == id);
            return ObjectMapper.Map<PersonDto>(person);
        }

        [HttpGet]
        public async Task<PersonDto> GetByUserIdAsync(int userId)
        {
            var person = _repository.GetAllIncluding(x => x.User).FirstOrDefault(x => x.User.Id == userId);
            return ObjectMapper.Map<PersonDto>(person);
        }

        [HttpGet]
        public async Task<List<PersonDto>> GetAllAsync()
        {
            var person = _repository.GetAllIncluding(x => x.User);
            return ObjectMapper.Map<List<PersonDto>>(person);
        }

        [HttpPatch]
        public async Task<PersonDto> UpdateAsync(PersonDto input)
        {
            var person = await _repository.GetAsync(input.Id);
            ObjectMapper.Map(input, person);
            person = await _repository.UpdateAsync(person);
            await CurrentUnitOfWork.SaveChangesAsync();
            return ObjectMapper.Map<PersonDto>(person);
        }

        [HttpDelete]
        public async Task DeleteAsync(Guid id)
        {
            await _repository.DeleteAsync(id);
        }

        private async Task<User> CreateUserAsync(CreatePersonDto input)
        {
            var password = string.IsNullOrEmpty(input?.Password) ? GeneratePassword(4) : input.Password;
            var user = ObjectMapper.Map<User>(input);
            user.Password = password;
            if (!string.IsNullOrEmpty(user.NormalizedUserName) && !string.IsNullOrEmpty(user.NormalizedEmailAddress))
                user.SetNormalizedNames();
            user.TenantId = AbpSession.TenantId;
            await _userManager.InitializeOptionsAsync(AbpSession.TenantId);
            CheckErrors(await _userManager.CreateAsync(user, password));

            if (input.RoleNames != null)
            {
                CheckErrors(await _userManager.SetRolesAsync(user, input.RoleNames));
            }

            CurrentUnitOfWork.SaveChanges();
            return user;
        }
        protected virtual void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }

        private string GeneratePassword(int length)
        {
            Random random = new Random();
            StringBuilder password = new StringBuilder();

            for (int i = 0; i < length; i++)
            {
                int index = random.Next(CharSet.Length);
                password.Append(CharSet[index]);
            }

            return "Pass@" + password.ToString();
        }
    }
}
