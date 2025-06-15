using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using AgenciaTurismo.Data;
using AgenciaTurismo.Domain.Entities;

namespace AgenciaTurismo.Web.Pages.Clientes;
public class DeleteModel : PageModel
{
    private readonly AgenciaTurismoContext _context;

    public Cliente Cliente { get; set; } = default!;

    public DeleteModel(AgenciaTurismoContext context)
    {
        _context = context;
    }

    public IActionResult OnGet(int id)
    {
        Cliente = _context.Clientes.Find(id)!;
        if (Cliente == null) return NotFound();
        return Page();
    }

    public IActionResult OnPost(int id)
    {
        var cliente = _context.Clientes.Find(id);
        if (cliente == null) return NotFound();

        _context.SaveChanges();

        return RedirectToPage("./Index");
    }
}