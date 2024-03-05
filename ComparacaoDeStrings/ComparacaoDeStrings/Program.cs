namespace ComparacaoDeStrings;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();

        var text = "Testando";

        // retorna um número como booleano
        // Console.WriteLine(text.CompareTo("testando"));

        // verifica se a string contem algo, desde uma letra a uma palavra completa
        // Console.WriteLine(text.Contains("Testando"));

        // ignora o case sensitive
        Console.WriteLine(text.Contains("testando", StringComparison.OrdinalIgnoreCase));
    }
}
