using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AgenciaTurismo.Domain.Entities
{
    public class Reserva
    {
        public int Id { get; set; }

        public int PacoteTuristicoId { get; set; }
        public int ClienteId { get; set; }

        [ForeignKey(nameof(PacoteTuristicoId))]
        public PacoteTuristico PacoteTuristico { get; set; } = null!;

        [ForeignKey(nameof(ClienteId))]
        public Cliente Cliente { get; set; } = null!;
    }
}
