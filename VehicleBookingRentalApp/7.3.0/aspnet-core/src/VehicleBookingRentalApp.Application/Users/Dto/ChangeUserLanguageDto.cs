using System.ComponentModel.DataAnnotations;

namespace VehicleBookingRentalApp.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}