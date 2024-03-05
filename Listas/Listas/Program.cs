namespace Listas;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();

        var lista = new int[8] { 5, 8, 3, 300, 5, 6, 8, 10 };

        Console.WriteLine(lista[3]);

        lista[0] = 500;

        Console.WriteLine(lista[0]);

        Console.WriteLine(lista.Max());

        Console.WriteLine("");
        Console.WriteLine("Lista de números: ");
        for (int i = 0; i < lista.Length; i++)
        {
            if (i < lista.Length - 1)
                Console.Write($"{lista[i]} - ");
            else
                Console.WriteLine(lista[i]);
        }

        // bubble sort
        var newArray = SortArray.Exec(lista);
        for (int i = 0; i < newArray.Length; i++)
        {
            if (i < newArray.Length - 1)
                Console.Write($"{newArray[i]} - ");
            else
                Console.WriteLine(newArray[i]);
        }
    }
}
