public class PDF : IExportavel, ISalvavel
{
    public void Exportar()
    {
        Console.WriteLine("PDF Exportado!");
    }

    public void Salvar()
    {
        Console.WriteLine("PDF Salvo!");
    }
}