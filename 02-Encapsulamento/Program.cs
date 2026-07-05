ContaBancaria contaJoao = new ContaBancaria("0001", "João");
ContaBancaria contaMaria = new ContaBancaria("0002", "Maria");

Console.WriteLine(contaJoao.Saldo);
Console.WriteLine(contaMaria.Saldo);

contaJoao.Depositar(10000);
contaMaria.Depositar(5000);

Console.WriteLine(contaJoao.Saldo);
Console.WriteLine(contaMaria.Saldo);

contaJoao.Sacar(2000);
contaMaria.Sacar(6000);

Console.WriteLine(contaJoao.Saldo);
Console.WriteLine(contaMaria.Saldo);