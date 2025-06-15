using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using AgenciaTurismo.Data;
using AgenciaTurismo.Domain.Entities;

namespace AgenciaTurismo.Web.Pages.Clientes;

public class CreateModel : PageModel
{
    private readonly AgenciaTurismoContext _context;

    [BindProperty]
    public Cliente Cliente { get; set; } = new();

    public CreateModel(AgenciaTurismoContext context)
    {
        _context = context;
    }

    public void OnGet() { }

    public IActionResult OnPost()
    {
        if (!ModelState.IsValid) return Page();

        _context.Clientes.Add(Cliente);
        _context.SaveChanges();

        return RedirectToPage("./Index");
    }
}