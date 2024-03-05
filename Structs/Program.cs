/*
  STRUCTS
  Tipos de dados estruturados
  É uma modelagem, um esqueleto
  Armazenam outros tipos de dados, tipo uma interface no ts que pode possuir outras interfaces ou types
  Possue nome com inicial maiúscula
*/

var products = new Products(1, "Mouse gamer", 299.87);

Console.WriteLine(products.Price);

struct Products
{
  public int Id;
  public string Title;
  public double Price;

  public Products(int id, string title, double price)
  {
    Id = id;
    Title = title;
    Price = price;
  }

  public double PriceInDolar(double dolar)
  {
    return Price * dolar;
  }
}