Produto produto1 = new Produto("Pendrive");
Produto produto2 = new Produto("Cartão SD");

var caixa = new Caixa<Produto>();

caixa.ExibirNomes();
caixa.Adicionar(produto1);
caixa.ExibirNomes();
caixa.Adicionar(produto2);
caixa.ExibirNomes();