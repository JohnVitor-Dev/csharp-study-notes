namespace Loja.Api.Models;

public class Produto
{

    public int Id { get; private set; }
    public string Name { get; private set; }
    public decimal Price { get; private set; }

    public Produto(string name, decimal price)
    {
        Name = name;
        Price = price;
    }

}