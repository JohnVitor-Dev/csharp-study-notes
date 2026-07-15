public class Botao
{
    public event EventHandler? Clicado;

    public void Clicar()
    {
        Console.WriteLine("Botão foi clicado.");

        Clicado?.Invoke(this, EventArgs.Empty);
    }
}