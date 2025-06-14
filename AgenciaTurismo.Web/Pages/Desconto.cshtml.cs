using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using AgenciaTurismo.Domain;
using AgenciaTurismo.Domain.Service;

public class DescontoModel : PageModel
{
    [BindProperty]
    public decimal? PrecoOriginal { get; set; }

    public decimal? PrecoComDesconto { get; set; }

    private readonly CalculateDelegate _descontoDelegate = DescontoHelper.AplicarDescontoDezPorCento;

    public void OnGet() { }

    public void OnPost()
    {
        if (PrecoOriginal is not null && PrecoOriginal > 0)
            PrecoComDesconto = _descontoDelegate(PrecoOriginal.Value);
    }
}