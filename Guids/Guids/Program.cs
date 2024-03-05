namespace Guids;

class Program
{
    static void Main(string[] args)
    {
        Guid id = Guid.NewGuid();

        // versão reduzida, dependendo do projeto pode ser útil para não ter um id imenso
        // aqui limito o guid a oito caracteres
        Console.WriteLine(id.ToString()[..8]);

        Console.WriteLine(id);
    }
}