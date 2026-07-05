using Banco;

Conta conta1 = new Conta();
Cliente cliente1 = new Cliente("João", "123.456.789-00");

Console.WriteLine(conta1.Saldo);
conta1.Sacar(50); // Tell don’t Ask
