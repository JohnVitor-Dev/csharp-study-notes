public class Caixa<T>
    where T : Produto
{
    private readonly List<T> _produtos = new();

    public IReadOnlyList<T> Produtos => _produtos;

    public void Adicionar(T produto)
    {
        _produtos.Add(produto);
    }

    public void Remover(T produto)
    {
        _produtos.Remove(produto);
    }

    public void ExibirNomes()
    {
        foreach (var produto in _produtos)
        {
            Console.WriteLine(produto.Nome);
        }
    }
}