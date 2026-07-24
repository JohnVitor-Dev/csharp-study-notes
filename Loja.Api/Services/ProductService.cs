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

    public List<Produto> GetAll()
    {
        return _context.Produtos.ToList();
    }

    public Produto? GetById(int id)
    {
        return _context.Produtos.FirstOrDefault(p => p.Id == id);
    }

    public Produto? Update(int id, UpdateProductRequest request)
    {
        var produto = _context.Produtos.FirstOrDefault(p => p.Id == id);

        if (produto is null)
            return null;

        produto.Rename(request.Name);
        produto.ChangePrice(request.Price);
        _context.SaveChanges();

        return produto;
    }

    public Produto? UpdateName(int id, UpdateNameProductRequest request)
    {
        var produto = _context.Produtos.FirstOrDefault(p => p.Id == id);

        if (produto is null)
            return null;

        produto.Rename(request.Name);
        _context.SaveChanges();

        return produto;
    }

    public Produto? UpdatePrice(int id, UpdatePriceProductRequest request)
    {
        var produto = _context.Produtos.FirstOrDefault(p => p.Id == id);

        if (produto is null)
            return null;

        produto.ChangePrice(request.Price);
        _context.SaveChanges();

        return produto;
    }

    public bool Delete(int id)
    {
        var produto = _context.Produtos.FirstOrDefault(p => p.Id == id);

        if (produto is null)
            return false;

        _context.Produtos.Remove(produto);
        _context.SaveChanges();

        return true;
    }
}