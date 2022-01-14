using static System.Console;

public class Program
{
    static void TrocarNome(Pessoa p1, string nomeNovo)
    {
        p1.Nome = nomeNovo;
    }
    public static void Main()
    {
        Pessoa p1 = new Pessoa();
        p1.Nome = "Pablo";
        p1.Idade = 21;
        p1.Documento = "123456789";

        TrocarNome(p1, "Matheus");

        WriteLine($"O novo nome é: {p1.Nome}");
    }
}