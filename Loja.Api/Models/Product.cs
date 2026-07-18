namespace Loja.Api.Models;

public class Produto
{

    public int ID { get; }
    public string Name { get; }
    public decimal Price { get; }

    public Produto(int Id, string name, decimal price)
    {
        ID = Id;
        Name = name;
        Price = price;
    }

    public static List<Produto> Produtos { get; } =
    [
        new Produto(1, "Notebook", 3500m),
        new Produto(2, "Mouse", 80m),
        new Produto(3, "Teclado", 150m)
    ];

}