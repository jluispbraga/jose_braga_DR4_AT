namespace AgenciaTurismo.Web.Helpers;

public static class FakeUserStore
{
    public static Dictionary<string, string> Users => new()
    {
        { "admin", "senha123" },
        { "user", "senhauser" }
    };
}
