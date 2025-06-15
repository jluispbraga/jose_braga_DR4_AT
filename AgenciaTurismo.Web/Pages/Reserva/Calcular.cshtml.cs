using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc;
using AgenciaTurismo.Domain.Services;

namespace AgenciaTurismo.Web.Pages.Reserva
{
    public class CalcularModel : PageModel
    {
        [BindProperty]
        public int Diarias { get; set; }

        [BindProperty]
        public int PrecoPorDia { get; set; }

        public decimal Total { get; set; }

        public void OnPost()
        {
            Total = ReservaCalculator.CalcularTotal(Diarias, PrecoPorDia);
        }
    }
}