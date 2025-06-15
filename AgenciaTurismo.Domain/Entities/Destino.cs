namespace AgenciaTurismo.Domain.Entities
{
    public class Destino
    {
        public int Id { get; set; }
        public string Nome { get; set; } = string.Empty;
        public string Pais { get; set; } = string.Empty;
    }
}