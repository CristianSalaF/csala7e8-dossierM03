using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using T4Ex22.Models;

namespace T4Ex22.Pages
{
    public class RegisterPageModel : PageModel
    {
        [BindProperty]
        public RegisterModel Register { get; set; } = new();
        public string? SuccessMessage { get; set; }

        public void OnGet()
        {
        }

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            SuccessMessage = "Registre completat correctament!";
            
            Register = new RegisterModel();
            
            return Page();
        }
    }
}
