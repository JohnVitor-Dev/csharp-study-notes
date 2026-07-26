using Loja.Api.Models;

public interface IProductService
{
    Produto Create(CreateProductRequest request);

    List<ProductResponse> GetAll();

    ProductResponse? GetById(int id);

    Produto? Update(int id, UpdateProductRequest request);

    Produto? UpdateName(int id, UpdateNameProductRequest request);

    Produto? UpdatePrice(int id, UpdatePriceProductRequest request);

    bool Delete(int id);

    List<ProductResponse> GetProductsAbovePrice(decimal price);

    List<ProductResponse> Search(string name);

    List<ProductResponse> GetOrderedByPrice();
}