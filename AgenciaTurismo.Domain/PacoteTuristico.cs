namespace AgenciaTurismo.Domain
{
    public class PacoteTuristico
    {
        public int Id { get; set; }
        public string Titulo { get; set; } = string.Empty;
        public DateTime DataInicio { get; set; }
        public int CapacidadeMaxima { get; set; }
        public decimal Preco { get; set; }

        public List<CidadeDestino> Destinos { get; set; } = new();
        public List<Reserva> Reservas { get; set; } = new();
    }
}