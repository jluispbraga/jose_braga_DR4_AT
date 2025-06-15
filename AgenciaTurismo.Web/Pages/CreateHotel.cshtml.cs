using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.ComponentModel.DataAnnotations;
using AgenciaTurismo.Domain.Entities;

namespace AgenciaTurismo.Web.Pages.Hoteis
{
    public class CreateHotelModel : PageModel
    {
        [BindProperty]
        public Hotel Hotel { get; set; } = new();

        public void OnGet()
        {
        }

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            return RedirectToPage("./Index");
        }
    }
}