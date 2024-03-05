namespace Equals;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        
        var text = "Cuida mininu";
        
        Console.WriteLine(text.Equals("Cuida mininu")); // true
        Console.WriteLine(text.Equals("cuida mininu")); // false
        Console.WriteLine(text.Equals("cuida mininu", StringComparison.OrdinalIgnoreCase)); // true
    }
}
