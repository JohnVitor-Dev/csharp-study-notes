public class ContaBancaria
{
    public string Numero { get; }

    public string Titular { get; }

    public decimal Saldo { get; private set; }

    public bool Ativa { get; private set; }

    public ContaBancaria(string numero, string titular)
    {
        Numero = numero;
        Titular = titular;
        Ativa = true;
    }

    public void Depositar(decimal valor)
    {
        if (valor <= 0)
            throw new ArgumentException("Valor inválido.");

        Saldo += valor;
    }

    public void Sacar(decimal valor)
    {
        if (!Ativa)
            throw new InvalidOperationException("Conta inativa.");

        if (valor <= 0)
            throw new ArgumentException();

        if (valor > Saldo)
            throw new InvalidOperationException("Saldo insuficiente.");

        Saldo -= valor;
    }

    public void Encerrar()
    {
        if (Saldo != 0)
            throw new InvalidOperationException("A conta deve estar zerada.");

        Ativa = false;
    }
}