class Program
{
    static void Main(string[] args)
    {
        Console.Clear();

        // DateTime? data = DateTime.Now; // podemos deixar nula

        var data = DateTime.Now;

        /*
        comparar com um if (data == DateTime.Now) não vai funcionar
        isso ocorre pq está sendo comparado toda a estrutura, o que inclui os milésimos de segundo
        logo nunca serão iguais
        */

        if (data.Date == DateTime.Now.Date)
            Console.WriteLine($"Today is {data.DayOfWeek} god dammn!");
        Console.WriteLine(string.Format("{0:dd/MM/yyyy}", data));
    }
}