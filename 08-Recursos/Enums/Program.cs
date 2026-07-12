var pedidoStatus = StatusPedido.Pendente;

Console.WriteLine(pedidoStatus);
Console.WriteLine((int)StatusPedido.Pago);

if (pedidoStatus == StatusPedido.Pago)
{
    Console.WriteLine("Liberar envio.");
}

if (pedidoStatus == StatusPedido.Pendente)
{
    Console.WriteLine("Pedido Pendente.");
}

Permissao permissao = Permissao.Ler | Permissao.Escrever;
Console.WriteLine(permissao);
Console.WriteLine(permissao.HasFlag(Permissao.Ler));
Console.WriteLine(permissao.HasFlag(Permissao.Excluir));