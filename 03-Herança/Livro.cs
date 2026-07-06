public class Livro : Produto
{
    public string Autor { get; }

    public Livro(string nome,
                  decimal preco,
                  string autor)
        : base(nome, preco)
    {
        Autor = autor;
    }
}