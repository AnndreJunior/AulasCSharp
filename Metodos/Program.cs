namespace Metodos
{
  class Program
  {
    public static void Main(string[] args)
    {
      Console.Write("Qual seu nome\nNome: ");
      string? nome = Console.ReadLine() ?? null;

      MeuMetodo();
      Console.WriteLine(RetornaNome(nome));
    }

    static void MeuMetodo()
    {
      Console.WriteLine("Chama");
    }

    static string? RetornaNome(string? nome)
    {
      string? nomeDoUsuario = (nome == null || nome.Length == 0) ? "Fulano" : nome.Trim();

      return nomeDoUsuario;
    }
  }
}