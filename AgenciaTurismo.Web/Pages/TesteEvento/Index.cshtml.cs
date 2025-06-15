using Microsoft.AspNetCore.Mvc.RazorPages;
using AgenciaTurismo.Domain.Entities;
using System;

using ReservaEntity = AgenciaTurismo.Domain.Entities.Reserva;

namespace AgenciaTurismo.Web.Pages.TesteEvento
{
    public class IndexModel : PageModel
    {
        public string MensagemEvento { get; set; }

        public void OnGet()
        {
            var pacote = new PacoteTuristico
            {
                Id = 1,
                Titulo = "Pacote Feriado",
                CapacidadeMaxima = 2
            };

            pacote.CapacityReached += (sender, args) =>
            {
                MensagemEvento = $"Capacidade máxima atingida para o pacote '{pacote.Titulo}'.";
                Console.WriteLine(MensagemEvento);
            };

            pacote.AdicionarReserva(new ReservaEntity { Id = 1 });
            pacote.AdicionarReserva(new ReservaEntity { Id = 2 });
            pacote.AdicionarReserva(new ReservaEntity { Id = 3 });

        }
    }
}