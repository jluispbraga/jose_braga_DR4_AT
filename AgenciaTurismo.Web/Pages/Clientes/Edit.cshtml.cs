using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using AgenciaTurismo.Data;
using AgenciaTurismo.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace AgenciaTurismo.Web.Pages.Clientes;

public class EditModel : PageModel
{
    private readonly AgenciaTurismoContext _context;

    [BindProperty]
    public Cliente Cliente { get; set; } = default!;

    public EditModel(AgenciaTurismoContext context)
    {
        _context = context;
    }

    public IActionResult OnGet(int id)
    {
        Cliente = _context.Clientes.Find(id)!;
        if (Cliente == null) return NotFound();
        return Page();
    }

    public IActionResult OnPost()
    {
        if (!ModelState.IsValid) return Page();

        _context.Attach(Cliente).State = EntityState.Modified;
        _context.SaveChanges();

        return RedirectToPage("./Index");
    }
}