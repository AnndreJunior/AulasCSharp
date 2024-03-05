namespace Datas;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();

        /*
        cria uma estrutura com valores padrão
        aqui podemos passar valores por parâmetro e criar um dado usando a estrutura do DateTime
        */
        // var data = new DateTime();

        // pega a data atual
        var data = DateTime.Now;

        var myBirthday = new DateTime(2006, 06, 05, 18, 30, 59); // ano, mês, dia, hora, min, segundos

        Console.WriteLine(data);
        Console.WriteLine(myBirthday.DayOfWeek); // dia da semana equivalente a data informada
        Console.WriteLine(myBirthday.Day); // dia informado em número

        var umDiaDeNascido = myBirthday.AddDays(1);
        Console.WriteLine($"Na data {(string.Format("{0:dd/MM/yyyy}", umDiaDeNascido))} havia se passado um dia desde que nasci");

        var nowDate = DateTime.Now;

        var formatedDate = string.Format("{0:dd/MM/yyyy - hh:mm:ss}", nowDate); //MM = mẽs, mm = minutos
        /*
        existem várias formas de formatar datas, qualquer coisa dá um google ou leia as docs
        sobre data
        */
        var shordDateTime = string.Format("{0:s}", nowDate);

        Console.WriteLine(formatedDate);
        Console.WriteLine(shordDateTime);

        Console.WriteLine(string.Format("{0:dd/MM/yyyy}", nowDate.AddDays(1))); // adiciona um dia na data informada
        Console.WriteLine(string.Format("{0:dd/MM/yyyy}", nowDate.AddMonths(1))); // adiciona um mês
        Console.WriteLine(string.Format("{0:dd/MM/yyyy}", nowDate.AddYears(1))); // adiciona um ano
    }
}
