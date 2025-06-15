using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace AgenciaTurismo.Domain.Entities
{
    public class Cliente
    {
        public int Id { get; set; }

        [Required, StringLength(150)]
        public string Nome { get; set; } = string.Empty;

        [Required, StringLength(150)]
        public string Email { get; set; } = string.Empty;
		
		public bool IsDeleted { get; set; } = false;
		
        public ICollection<Reserva> Reservas { get; set; } = new List<Reserva>();
    }
}
