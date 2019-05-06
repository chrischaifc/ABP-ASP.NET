using System.ComponentModel.DataAnnotations;

namespace MYABP.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}