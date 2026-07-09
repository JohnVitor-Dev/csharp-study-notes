public class Produto
{
    private string _nome;
    public string Nome => _nome;

    public Produto(string nome)
    {
        _nome = nome;
    }
}