namespace AgenciaTurismo.Domain.Services{
    public static class ReservaCalculator
    {
        public static Func<int, int, decimal> CalcularTotal = (diarias, precoPorDia) => diarias * precoPorDia;
    }
}