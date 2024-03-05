using System.Globalization;

namespace Moedas;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();

        /*
        geralmente é mais comum usar o tipo decimal para trabalhar com moedas por conta da precisão dele
        não é regra, pode sim usar double ou float, mas o decimal é mais usado e recomendado
        */
        decimal value = 10.52M;
        var brazilianCulture = CultureInfo.CreateSpecificCulture("pt-BR");
        Console.WriteLine(value.ToString("C", brazilianCulture)); // o formatador C formata de forma monetária da cultura, nesse caso R$ 10,50
        Console.WriteLine(value.ToString("F", brazilianCulture)); // aumenta a precisão do número

        Console.WriteLine(Math.Round(value)); // valor arredondado
        Console.WriteLine(Math.Ceiling(value)); // arreonda pra cima
        Console.WriteLine(Math.Floor(value)); // arredonda pra baixo
    }
}
