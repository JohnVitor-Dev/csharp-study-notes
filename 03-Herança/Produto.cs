public class Produto
{
    public string Nome { get; }

    public decimal Preco { get; protected set; }

    public Produto(string nome, decimal preco)
    {
        Nome = nome;
        Preco = preco;
    }
}