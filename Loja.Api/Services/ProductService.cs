using Loja.Api.Models;

public class ProductService : IProductService
{
    private readonly AppDbContext _context;

    public ProductService(AppDbContext context)
    {
        _context = context;
    }

    public Produto Create(CreateProductRequest request)
    {
        var produto = new Produto(request.Name, request.Price);

        _context.Produtos.Add(produto);
        _context.SaveChanges();

        return produto;
    }
}