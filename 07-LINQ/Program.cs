
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

// Take pegue os x primeiros elementos
// Skip ignore os x elementos
void Paginacao()
{
    var primeirosClientes = BancoFake.Clientes.Take(3);
    var produtosBaratos = BancoFake.Produtos.OrderBy(p => p.Preco).Take(5);
    var segundaPaginaClientes = BancoFake.Clientes.Skip(3).Take(3);
    var produtosCaros = BancoFake.Produtos.OrderByDescending(p => p.Preco).Take(4);
}

// GroupBy cria grupos na mesma coleção
void Group()
{
    var clientesNasCidades = BancoFake.Clientes.GroupBy(c => c.Cidade).Select(g => new { Cidade = g.Key, Quantidade = g.Count() });
    var produtosNasCategorias = BancoFake.Produtos.GroupBy(p => p.CategoriaId).Select(g => new { CategoriaId = g.Key, Quantidade = g.Count() });
    var precoMedioProdutosDaCategoria = BancoFake.Produtos.GroupBy(p => p.CategoriaId).Select(g => new { CategoriaId = g.Key, PrecoMedio = g.Average(p => p.Preco) });
    var clienteAtivoNaCidade = BancoFake.Clientes.Where(c => c.Ativo).GroupBy(c => c.Cidade).Select(g => new { Cidade = g.Key, QuantidadeAtivo = g.Count() });
    var produtoMaisCaroNaCategoria = BancoFake.Produtos.GroupBy(p => p.CategoriaId).Select(g => g.MaxBy(p => p.Preco));

}

// Join junta duas coleções diferentes
void Join()
{
    var clientePedidoData = BancoFake.Pedidos.Join(
    BancoFake.Clientes,
    pedido => pedido.ClienteId,
    cliente => cliente.Id,
    (pedido, cliente) => new
    {
        Cliente = cliente.Nome,
        pedido.Data
    });

    var pedidos = BancoFake.Produtos.Join(
    BancoFake.ItensPedido,
    produtos => produtos.Id,
    itenspedidos => itenspedidos.ProdutoId,
    (produtos, itenspedidos) => new
    {
        Nome = produtos.Nome,
        Quantidade = itenspedidos.Quantidade
    });

    var clienteNomeCidadePedido = BancoFake.Pedidos.Join(
    BancoFake.Clientes,
    pedido => pedido.ClienteId,
    cliente => cliente.Id,
    (pedido, cliente) => new
    {
        Cliente = cliente.Nome,
        pedido.Id,
        Cidade = cliente.Cidade
    });
}
