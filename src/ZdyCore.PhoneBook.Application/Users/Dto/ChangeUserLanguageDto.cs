using System.ComponentModel.DataAnnotations;

namespace ZdyCore.PhoneBook.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}