
using EstudoLINQ;
#pragma warning disable CS8321

// Where decide quais elementos continuam
void Where()
{
    var clientesIdadeMaior18 = BancoFake.Clientes.Where(i => i.Idade >= 18);
    foreach (var item in clientesIdadeMaior18)
    {
        Console.WriteLine(item.Nome);
    }
}

// Select tranforma os elementos
void Select()
{
    // Novo Objeto, mas poderia ser somente um item e esse item seria tranformado.
    // O Where poderia ser usado junto também
    var quantidadeBaixaProdutosEstoque = BancoFake.Produtos.Select(e => new
    {
        e.Nome,
        e.Estoque
    });
    foreach (var item in quantidadeBaixaProdutosEstoque)
    {
        Console.WriteLine($"{item.Nome} | {item.Estoque}");
    }
}

// OrderBy/OrderByDescending/ThenBy ordena os elementos
void Order()
{
    var clientesOrdenados = BancoFake.Clientes.OrderBy(c => c.Cidade).ThenBy(n => n.Nome);
    foreach (var item in clientesOrdenados)
    {
        Console.WriteLine($"{item.Cidade} | {item.Nome}");
    }
}

// First/FirstOrDefault
// First: Primeiro encontrado
// FirstOrDefault: Primeiro encontrado ou Default
void First()
{
    var primeiroProduto = BancoFake.Produtos.First();
    var primeiroProdutoEstoqueMaiorQueZero = BancoFake.Produtos.FirstOrDefault(p => p.Estoque > 0);
    Console.WriteLine(primeiroProduto.Nome);
    if (primeiroProdutoEstoqueMaiorQueZero != null) Console.WriteLine(primeiroProdutoEstoqueMaiorQueZero.Nome);
}

// Single/SingleOrDefault
// Single: Somente um
// SingleOrDefault: Um ou Default
void Single()
{
    var clienteID = BancoFake.Clientes.Single(c => c.Id == 3);
    var clienteIDOrDefault = BancoFake.Clientes.SingleOrDefault(c => c.Id == 3);
    Console.WriteLine(clienteID.Id);
    if (clienteIDOrDefault != null) Console.WriteLine(clienteIDOrDefault.Id);
}

// Any Existe pelo menos um?
// All Todos atendem ao requisito?
void AnyAndAll()
{
    // Existe algum pedido do cliente do ID 5?
    var existeAlgumPedidoDoCliente = BancoFake.Pedidos.Any(p => p.ClienteId == 5);
    // Todos os produtos tem estoque maior que 0?
    var todosOsProdutosTemEstoque = BancoFake.Produtos.All(p => p.Estoque > 0);

    Console.WriteLine(existeAlgumPedidoDoCliente);
    Console.WriteLine(todosOsProdutosTemEstoque);
}

// Count() Contar
// LongCount
// Sum() Somar
// Average() Nédia
// Min() Menor Valor
// Max() Maior Valor
void Agregacao()
{
    var quantidadeClientesAtivos = BancoFake.Clientes.Count(c => c.Ativo);
    var somaPrecoProdutos = BancoFake.Produtos.Sum(p => p.Preco);
    var mediaPrecoProdutos = BancoFake.Produtos.Average(p => p.Preco);
    var menorPrecoProdutos = BancoFake.Produtos.Min(p => p.Preco);
    var maiorPrecoProdutos = BancoFake.Produtos.Max(p => p.Preco);

    Console.WriteLine(quantidadeClientesAtivos);
    Console.WriteLine(somaPrecoProdutos);
    Console.WriteLine(mediaPrecoProdutos);
    Console.WriteLine(menorPrecoProdutos);
    Console.WriteLine(maiorPrecoProdutos);

}


