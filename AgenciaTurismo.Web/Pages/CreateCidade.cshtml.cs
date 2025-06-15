using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.ComponentModel.DataAnnotations;

namespace AgenciaTurismo.Web.Pages.Cidades
{
    public class CreateCidadeModel : PageModel
    {
        [BindProperty]
        public CidadeInputModel Cidade { get; set; } = new();

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

    public class CidadeInputModel
    {
        [Required(ErrorMessage = "O nome é obrigatório.")]
        [MinLength(3, ErrorMessage = "O nome deve ter pelo menos 3 caracteres.")]
        public string Nome { get; set; } = string.Empty;
    }
}