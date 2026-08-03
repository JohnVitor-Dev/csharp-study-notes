using Loja.Api.Models;
using Microsoft.EntityFrameworkCore;

public class CategoryService : ICategoryService
{
    private readonly AppDbContext _context;

    public CategoryService(AppDbContext context)
    {
        _context = context;
    }

    public Categoria Create(CreateCategoryRequest request)
    {
        var categoria = new Categoria(request.Name);

        _context.Categorias.Add(categoria);
        _context.SaveChanges();

        return categoria;
    }

    public List<CategoryResponse> GetAll()
    {
        return _context.Categorias
        .AsNoTracking()
        .Select(c => new CategoryResponse(
            c.Id,
            c.Name
        ))
        .ToList();
    }

    public CategoryResponse? GetById(int id)
    {
        return _context.Categorias
        .AsNoTracking()
        .Where(c => c.Id == id)
        .Select(c => new CategoryResponse(
            c.Id,
            c.Name
        ))
        .FirstOrDefault();
    }

    public CategoryResponse? UpdateName(int id, UpdateNameCategoryRequest request)
    {
        var categoria = _context.Categorias.FirstOrDefault(c => c.Id == id);

        if (categoria is null)
            return null;

        categoria.Rename(request.Name);
        _context.SaveChanges();

        return new CategoryResponse(categoria.Id, categoria.Name);
    }

    public bool Delete(int id)
    {
        var categoria = _context.Categorias.FirstOrDefault(c => c.Id == id);

        if (categoria is null)
            return false;

        _context.Categorias.Remove(categoria);
        _context.SaveChanges();

        return true;
    }

    public List<CategoryResponse> Search(string name)
    {
        return _context.Produtos
        .AsNoTracking()
        .Where(p => p.Name.Contains(name))
        .Select(p => new CategoryResponse(
            p.Id,
            p.Name
        ))
        .ToList();
    }

}