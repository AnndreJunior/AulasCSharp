namespace StartsWithEndsWith;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();

        var text = "Esse texto passa alguma mensagem";

        Console.WriteLine(text.StartsWith("Esse"));
        // ignora o case sensitive
        // Console.WriteLine(text.StartsWith("esse", StringComparison.OrdinalIgnoreCase));
        Console.WriteLine(text.StartsWith("esse"));
        Console.WriteLine(text.EndsWith("mensagem"));
    }
}
