class Program
{
    static void Main(string[] args)
    {
        Console.Clear();

        /*
        Muito usado para realizar calculos que envolvem horas
        Pode ser útil para a criação de um projeto de bater ponto
        */
        var timeSpan = new TimeSpan(4, 30, 28); // 04:30:28
        Console.WriteLine(timeSpan);
    }
}