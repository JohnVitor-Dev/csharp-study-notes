namespace Loja.Api.Models;

public class Categoria
{
    public int Id { get; private set; }

    public string Nome { get; private set; }

    private readonly List<Produto> _produtos = [];

    public IReadOnlyCollection<Produto> Produtos => _produtos;

    public Categoria(string nome)
    {
        Nome = nome;
    }
}