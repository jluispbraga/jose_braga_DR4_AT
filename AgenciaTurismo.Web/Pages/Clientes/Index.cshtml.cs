using AgenciaTurismo.Data;
using AgenciaTurismo.Domain.Entities;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace AgenciaTurismo.Web.Pages.Clientes;

public class IndexModel : PageModel
{
    private readonly AgenciaTurismoContext _context;

    public IndexModel(AgenciaTurismoContext context)
    {
        _context = context;
    }

    public IList<Cliente> Clientes { get; set; } = default!;

    public void OnGet()
    {
        Clientes = _context.Clientes.Where(c => !c.IsDeleted).ToList();
    }
}