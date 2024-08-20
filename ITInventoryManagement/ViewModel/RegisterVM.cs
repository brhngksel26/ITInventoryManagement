using System.ComponentModel.DataAnnotations;

namespace ITInventoryManagement.ViewModel
{
    public class RegisterVM
    {
        [Required(ErrorMessage = "Name is required.")]
        public string? Name { get; set; }

        [Required(ErrorMessage = "Email is required. ")]
        [DataType(DataType.EmailAddress)]
        public string? Email { get; set; }

        [Required(ErrorMessage = "Passwond is required. ")]
        [DataType(DataType.Password)]
        public string? Password { get; set; }

        [Compare("Password", ErrorMessage = "Passwond is required. ")]
        public string? ConfirmPassword { get; set; }


    }
}
