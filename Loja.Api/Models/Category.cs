namespace Loja.Api.Models;

public class Categoria
{
    public int Id { get; private set; }

    public string Name { get; private set; }

    private readonly List<Produto> _produtos = [];

    public IReadOnlyCollection<Produto> Produtos => _produtos;

    public Categoria(string name)
    {
        Name = name;
    }

    public void Rename(string name)
    {
        if (string.IsNullOrWhiteSpace(name))
            throw new ArgumentException("O campo de nome está vazio ou com espaço em branco!");

        Name = name;
    }
}