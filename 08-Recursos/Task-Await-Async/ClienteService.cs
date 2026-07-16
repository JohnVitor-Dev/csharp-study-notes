public class ClienteService
{
    public async Task<List<string>> BuscarClientesAsync()
    {
        Console.WriteLine("Buscando clientes no banco...");
        
        await Task.Delay(3000);

        return new List<string>
        {
            "João",
            "Maria",
            "Carlos"
        };
    }
}