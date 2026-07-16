ClienteService service = new ClienteService();

Console.WriteLine("Iniciou");

Task<List<string>> tarefa = service.BuscarClientesAsync();

Console.WriteLine("Enquanto busca os clientes...");
Console.WriteLine("Posso fazer outras coisas...");

List<string> clientes = await tarefa;

Console.WriteLine("Clientes encontrados:");

foreach (var cliente in clientes)
{
    Console.WriteLine(cliente);
}

Console.WriteLine("Fim");