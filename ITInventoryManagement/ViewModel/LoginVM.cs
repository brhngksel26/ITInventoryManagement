using System.ComponentModel.DataAnnotations;

namespace ITInventoryManagement.ViewModel
{
    public class LoginVM
    {
        [Required(ErrorMessage = "Usernane is required.")]
        public string? Username { get; set; }

        [Required(ErrorMessage = "Passwond is required. ")]
        [DataType(DataType.Password)]
        public string? Password { get; set; }

        [Display(Name = "Remember Me")]
        public bool RememberMe { get; set; }
    }
}
