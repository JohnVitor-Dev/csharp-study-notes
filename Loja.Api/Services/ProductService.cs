using Loja.Api.Models;

public class ProductService
{
    public Produto Create(CreateProductRequest request)
    {
        var produto = new Produto(Random.Shared.Next(1, 100), request.Name, request.Price);

        return produto;
    }
}