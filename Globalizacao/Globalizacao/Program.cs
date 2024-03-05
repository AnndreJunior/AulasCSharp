using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();

        var ptBr = new CultureInfo("pt-BR");
        var pt = new CultureInfo("pt-PT");
        var enUs = new CultureInfo("en-US");
        var atual = CultureInfo.CurrentCulture; // pega a cultura da máquina

        Console.WriteLine(DateTime.Now.ToString("dd/MM/yyyy", ptBr));
    }
}
