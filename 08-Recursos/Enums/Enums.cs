public enum StatusPedido
{
    Pendente,
    Pago,
    Enviado,
    Cancelado
}

[Flags]
public enum Permissao
{
    Nenhuma = 0,
    Ler = 1,
    Escrever = 2,
    Excluir = 4
}