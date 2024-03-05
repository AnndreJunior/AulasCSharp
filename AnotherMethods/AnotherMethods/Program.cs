namespace AnotherMethods;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();

        string text = "Este texto é um teste";

        Console.WriteLine(text.ToUpper());
        Console.WriteLine(text.ToLower());

        // adiciona alguma palavra a partir do índice 5
        // nesse caso adiciona a palavra RECEBA
        Console.WriteLine(text.Insert(5, "RECEBA "));

        // remove a, partir de algum índice, um número x de caracteres
        // nesse caso, a partir do índice 5, remove os próximos 6 caracteres
        Console.WriteLine(text.Remove(5, 6));

        // substitui algum caracter/palavra por outro
        // aqui ele substitui a palavra Este para Isto
        Console.WriteLine(text.Replace("Este", "Isto"));

        Console.WriteLine("");

        var divisao = text.Split(" ");

        for (int i = 0; i < divisao.Length; i++)
        {
            Console.WriteLine(divisao[i]);
        }
    }
}
