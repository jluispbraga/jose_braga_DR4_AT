namespace AgenciaTurismo.Domain
{
    public delegate decimal CalculateDelegate(decimal precoOriginal);

    public static class DescontoHelper
    {
        public static decimal AplicarDescontoDezPorCento(decimal preco)
        {
            return preco * 0.9m;
        }
    }
}