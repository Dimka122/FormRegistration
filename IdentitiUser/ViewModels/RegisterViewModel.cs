using System.ComponentModel.DataAnnotations;

namespace IdentitiUser.ViewModels
{
    public class RegisterViewModel
    {
        [Required]
        [Display(Name = "Email")]
        [DataType(DataType.EmailAddress, ErrorMessage = "Не корректный Email")]
        public string Email { get; set; }
        [Required]
        [Display(Name ="Год рождения")]
        public int Year { get; set; }
        [Required]
        [DataType(DataType.Password)]
        [Display(Name ="Пароль")]
        public string? Password { get; set; }
        [Required]
        [Compare("Password",ErrorMessage ="Пароли не совпадают")]
        [DataType(DataType.Password)]
        [Display(Name ="Потвердить пароль")]
        public string ConfirmPassword { get; set;}
    }
}
