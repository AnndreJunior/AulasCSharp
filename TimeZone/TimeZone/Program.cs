class Program
{
    static void Main(string[] args)
    {
        Console.Clear();

        var defaultDate = DateTime.UtcNow; // pega a data atual em formato utc, sem timezone
        Console.WriteLine(defaultDate);
        Console.WriteLine(defaultDate.ToLocalTime()); // data atual no formato da máquina

        var austriliaTimeZone = TimeZoneInfo.FindSystemTimeZoneById("Pacific/Auckland");
        var austriliaTime = TimeZoneInfo.ConvertTimeFromUtc(defaultDate, austriliaTimeZone); // pega o horário em utc e converte para o padrão da australia

        Console.WriteLine($"Data na Australia {austriliaTime}");

        var timezones = TimeZoneInfo.GetSystemTimeZones(); // pega uma lista com os timezones disponíveis

        foreach (var timezone in timezones)
        {
            Console.WriteLine(timezone.Id);
            Console.WriteLine(timezone);
        }
    }
}