using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace AgenciaTurismo.Domain.Entities
{
    public class PacoteTuristico
    {
        public int Id { get; set; }

        [Required, StringLength(100)]
        public string Titulo { get; set; } = string.Empty;

        public int CapacidadeMaxima { get; set; }

        public ICollection<Reserva> Reservas { get; set; } = new List<Reserva>();
    }
}
