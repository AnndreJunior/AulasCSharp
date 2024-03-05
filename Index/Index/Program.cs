namespace Index;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();

        var text = "Esse texto é um teste";

        Console.WriteLine(text.IndexOf('E'));
        Console.WriteLine(text.IndexOf('e'));
        Console.WriteLine(text.LastIndexOf('e'));
    }
}
