namespace AgenciaTurismo.Domain
{
    public class CidadeDestino
    {
        public int Id { get; set; }
        public string Nome { get; set; } = string.Empty;

        public int PaisDestinoId { get; set; }
        public PaisDestino Pais { get; set; } = null!;
    }
}