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

    public void Rename(string name)
    {
        if (string.IsNullOrWhiteSpace(name))
            throw new NullReferenceException("O campo de nome está vazio ou com espaço em branco!");

        Name = name;
    }

    public void ChangePrice(decimal price)
    {
        Price = price;
    }

}