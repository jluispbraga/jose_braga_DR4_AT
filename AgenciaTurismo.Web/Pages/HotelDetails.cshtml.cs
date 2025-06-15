using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using AgenciaTurismo.Domain.Entities;

namespace AgenciaTurismo.Web.Pages.Hoteis;

public class HotelDetailsModel : PageModel
{
    public Hotel? Hotel { get; set; }

    public void OnGet(int id)
    {
        var listaHoteis = new List<Hotel>
        {
            new Hotel { Id = 1, Nome = "Hotel Mar Azul", Endereco = new Endereco { Rua = "Rua das Flores", Cidade = "São Paulo" } },
            new Hotel { Id = 2, Nome = "Hotel Sol", Endereco = new Endereco { Rua = "Rua do Sol", Cidade = "Rio de Janeiro" } },
        };

        Hotel = listaHoteis.FirstOrDefault(h => h.Id == id);
    }
}
