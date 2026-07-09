public class Imagem : IExportavel, ISalvavel
{
    public void Exportar()
    {
        Console.WriteLine("Imagem Exportada!");
    }

    public void Salvar()
    {
        Console.WriteLine("Imagem Salva!");
    }
}