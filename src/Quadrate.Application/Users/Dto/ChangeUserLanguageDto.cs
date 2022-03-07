using System.ComponentModel.DataAnnotations;

namespace Quadrate.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}