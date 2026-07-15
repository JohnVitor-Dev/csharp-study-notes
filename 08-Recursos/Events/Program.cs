Botao botao = new();
Tela tela = new();

botao.Clicado += tela.MostrarMensagem;
botao.Clicado += tela.TocarSom;

botao.Clicar();