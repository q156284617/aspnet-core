using System.ComponentModel.DataAnnotations;

namespace WebProject.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}