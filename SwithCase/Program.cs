/*
  o switch case funciona de forma similar com o if/else
  switch (condition)
  {
    case x:
      // alguma ação
      break;
    case y:
      // outra ação
      break;
    default:
      // ação padrão
      break;
  }

  o default funciona como o else, se nada for verdadeiro ele faz uma ação por padrão (default)
*/

// string name = "Fabrício";
// string name = "João";
string name = "André";

switch (name)
{
  case "João":
    Console.WriteLine("Não é o cara");
    break;
  case "Marcelo":
    Console.WriteLine("Não é o cara");
    break;
  case "André":
    Console.WriteLine("É o cara");
    break;
  default:
    Console.WriteLine("Não encontrei");
    break;
}