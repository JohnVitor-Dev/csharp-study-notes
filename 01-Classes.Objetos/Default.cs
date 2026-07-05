namespace Banco
{
    public class Conta

    {
        private decimal _saldo;

        public decimal Saldo => _saldo;

        public void Sacar(decimal valor)
        {
            if (valor <= 0)
                throw new ArgumentException();

            if (valor > _saldo)
                throw new InvalidOperationException();

            _saldo -= valor;
        }
    }

    public class Cliente
    {
        public string Nome { get; }

        public string Cpf { get; }
        public Cliente(string nome, string cpf)
        {
            if (string.IsNullOrWhiteSpace(nome))
                throw new ArgumentException();

            Nome = nome;
            Cpf = cpf;
        }

    }
}