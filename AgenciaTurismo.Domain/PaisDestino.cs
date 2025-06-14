namespace AgenciaTurismo.Domain
{
    public class PaisDestino
    {
        public int Id { get; set; }
        public string Nome { get; set; } = string.Empty;

        public List<CidadeDestino> Cidades { get; set; } = new();
    }
}