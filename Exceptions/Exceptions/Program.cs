namespace Exceptions;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();

        var array = new int[3] { 1, 2, 3 };

        try
        {
            // throws error
            // ValidateString(null);
            ValidateString("");
            // ValidateString("Cuida");

            // it works
            // for (int i = 0; i < 3; i++)
            //     Console.WriteLine(array[i]);
            //  throws error
            for (int i = 0; i < 5; i++)
                Console.WriteLine(array[i]);
        }
        catch (IndexOutOfRangeException)
        {
            Console.Clear();

            Console.WriteLine("Oxi porra");
        }
        catch (ArgumentNullException err)
        {
            Console.WriteLine(err.Message);
        }
        catch (Exception)
        {
            Console.Clear();

            Console.WriteLine("Erro interno");
        }
    }

    static void ValidateString(string msg)
    {
        if (string.IsNullOrEmpty(msg))
            throw new ArgumentNullException("Informe o texto, porra");
    }
}
