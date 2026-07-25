using Loja.Api.Models;

public interface IProductService
{
    Produto Create(CreateProductRequest request);

    List<Produto> GetAll();

    Produto? GetById(int id);

    Produto? Update(int id, UpdateProductRequest request);

    Produto? UpdateName(int id, UpdateNameProductRequest request);

    Produto? UpdatePrice(int id, UpdatePriceProductRequest request);

    bool Delete(int id);

    List<Produto> GetProductsAbovePrice(decimal price);

    List<Produto> Search(string name);

    List<Produto> GetOrderedByPrice();
}