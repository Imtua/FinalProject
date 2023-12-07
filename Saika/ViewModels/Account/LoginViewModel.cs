using System.ComponentModel.DataAnnotations;

namespace Saika.ViewModels.Account
{
    public class LoginViewModel
    {
        [Required]
        [Display(Name ="Логин")]
        public string Login { get; set; }

        [Required]
        [Display(Name ="Пароль")]
        public string Password { get; set; }
    }
}
