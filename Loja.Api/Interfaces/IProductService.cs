using Loja.Api.Models;

public interface IProductService
{
    Produto Create(CreateProductRequest request);
}