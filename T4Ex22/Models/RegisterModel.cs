using System.ComponentModel.DataAnnotations;

namespace T4Ex22.Models
{
    public class RegisterModel
    {
        [Required(ErrorMessage = "El nom és obligatori")]
        [StringLength(50, ErrorMessage = "El nom no pot superar els 50 caràcters")]
        public string Name { get; set; } = string.Empty;

        [Required(ErrorMessage = "El correu electrònic és obligatori")]
        [EmailAddress(ErrorMessage = "El format del correu electrònic no és vàlid")]
        public string Email { get; set; } = string.Empty;

        [Required(ErrorMessage = "La contrasenya és obligatòria")]
        [StringLength(100, MinimumLength = 6, ErrorMessage = "La contrasenya ha de tenir entre 6 i 100 caràcters")]
        [DataType(DataType.Password)]
        public string Password { get; set; } = string.Empty;
    }
}
