using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CakeSale_GemmaWorkExperience.Pages
{
    public class RequestCakeModel : PageModel
    {
        [BindProperty]
        [Required(ErrorMessage = "Your customer errror message")]
        public string customername { get; set; }
        [BindProperty]
        public string caketype { get; set; }
        public void OnGet()
        {

        }
        public IActionResult OnPost()
        {
            if (!ModelState.IsValid) { return Page(); }
            return Page();

        }
    }
}