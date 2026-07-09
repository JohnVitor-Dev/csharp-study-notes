namespace EstudoLINQ;

public record Categoria(int Id, string Nome);

public record Cliente(
    int Id,
    string Nome,
    int Idade,
    string Cidade,
    bool Ativo);

public record Produto(
    int Id,
    string Nome,
    int CategoriaId,
    decimal Preco,
    int Estoque);

public record Pedido(
    int Id,
    int ClienteId,
    DateTime Data);

public record ItemPedido(
    int Id,
    int PedidoId,
    int ProdutoId,
    int Quantidade,
    decimal ValorUnitario);

public static class BancoFake
{
    public static List<Categoria> Categorias =
    [
        new(1,"Informática"),
        new(2,"Celulares"),
        new(3,"Áudio"),
        new(4,"Games"),
        new(5,"Móveis"),
        new(6,"Eletrodomésticos"),
        new(7,"Livros"),
        new(8,"Esportes")
    ];

    public static List<Cliente> Clientes =
    [
        new(1,"Ana Clara",22,"São Paulo",true),
        new(2,"Bruno Henrique",35,"Rio de Janeiro",true),
        new(3,"Carlos Eduardo",28,"Curitiba",false),
        new(4,"Daniela Souza",31,"Fortaleza",true),
        new(5,"Eduardo Lima",45,"Recife",true),
        new(6,"Fernanda Alves",19,"Salvador",false),
        new(7,"Gabriel Oliveira",27,"Brasília",true),
        new(8,"Helena Martins",39,"São Paulo",true),
        new(9,"Igor Costa",24,"Natal",true),
        new(10,"Juliana Pereira",30,"Manaus",false),
        new(11,"Kaio Rodrigues",21,"João Pessoa",true),
        new(12,"Larissa Gomes",33,"Campina Grande",true),
        new(13,"Marcos Vinicius",42,"São Paulo",true),
        new(14,"Natália Fernandes",26,"Belém",false),
        new(15,"Otávio Rocha",37,"Curitiba",true),
        new(16,"Paula Carvalho",29,"Recife",true),
        new(17,"Rafael Araújo",32,"Salvador",true),
        new(18,"Sofia Batista",23,"Fortaleza",false),
        new(19,"Tiago Nunes",18,"Brasília",true),
        new(20,"Vanessa Moura",36,"Natal",true),
        new(21,"William Castro",38,"São Luís",true),
        new(22,"Yasmin Freitas",20,"Aracaju",true),
        new(23,"João Pedro",16,"Maceió",true),
        new(24,"Amanda Ribeiro",27,"Florianópolis",true),
        new(25,"Lucas Silva",29,"São Paulo",false),
        new(26,"Bianca Melo",14,"Recife",true),
        new(27,"Caio Henrique",31,"Curitiba",true),
        new(28,"Débora Santos",25,"Belém",true),
        new(29,"Felipe Duarte",44,"Goiânia",true),
        new(30,"Giovana Lima",17,"Rio Branco",true),
        new(31,"Henrique Farias",23,"Macapá",false),
        new(32,"Isabela Ramos",37,"Porto Alegre",true),
        new(33,"José Carlos",16,"São Paulo",true),
        new(34,"Karen Almeida",34,"Vitória",true),
        new(35,"Leonardo Barros",28,"João Pessoa",true),
        new(36,"Marina Teixeira",30,"Fortaleza",true),
        new(37,"Nathan Lopes",22,"Recife",false),
        new(38,"Patrícia Cunha",15,"Manaus",true),
        new(39,"Renato Ferreira",33,"Curitiba",true),
        new(40,"Tatiane Moraes",27,"São Paulo",true)
    ];

    public static List<Produto> Produtos =
    [
        new(1,"Notebook Dell",1,4500,15),
        new(2,"Notebook Lenovo",1,3900,12),
        new(3,"Notebook Acer",1,3700,10),
        new(4,"Mouse Gamer",1,180,80),
        new(5,"Teclado Mecânico",1,420,50),
        new(6,"Monitor 24\"",1,980,20),
        new(7,"Monitor 27\"",1,1450,15),
        new(8,"SSD 1TB",1,650,40),
        new(9,"HD Externo 2TB",1,520,35),
        new(10,"Impressora Epson",1,980,12),

        new(11,"Samsung Galaxy S25",2,4200,18),
        new(12,"iPhone 16",2,7600,10),
        new(13,"Moto G",2,1800,30),
        new(14,"Xiaomi Redmi",2,2100,25),

        new(15,"Fone Bluetooth",3,250,90),
        new(16,"Headset Gamer",3,480,45),
        new(17,"Caixa de Som JBL",3,890,22),

        new(18,"PlayStation 5",4,4300,8),
        new(19,"Xbox Series X",4,4100,9),
        new(20,"Controle Xbox",4,390,40),

        new(21,"Mesa Escritório",5,700,15),
        new(22,"Cadeira Gamer",5,1300,10),
        new(23,"Estante",5,580,18),

        new(24,"Air Fryer",6,540,25),
        new(25,"Liquidificador",6,230,40),
        new(26,"Micro-ondas",6,760,18),

        new(27,"Clean Code",7,120,70),
        new(28,"Domain-Driven Design",7,220,30),

        new(29,"Bola de Futebol",8,110,50),
        new(30,"Bicicleta Aro 29",8,1800,12)
    ];

    public static List<Pedido> Pedidos =
    [
        new(1,1,new DateTime(2025,1,5)),
        new(2,2,new DateTime(2025,1,8)),
        new(3,3,new DateTime(2025,1,10)),
        new(4,4,new DateTime(2025,1,12)),
        new(5,5,new DateTime(2025,1,18)),
        new(6,6,new DateTime(2025,1,25)),
        new(7,7,new DateTime(2025,2,2)),
        new(8,8,new DateTime(2025,2,6)),
        new(9,9,new DateTime(2025,2,10)),
        new(10,10,new DateTime(2025,2,15)),
        new(11,11,new DateTime(2025,2,18)),
        new(12,12,new DateTime(2025,2,22)),
        new(13,13,new DateTime(2025,3,1)),
        new(14,14,new DateTime(2025,3,4)),
        new(15,15,new DateTime(2025,3,8)),
        new(16,16,new DateTime(2025,3,10)),
        new(17,17,new DateTime(2025,3,15)),
        new(18,18,new DateTime(2025,3,18)),
        new(19,19,new DateTime(2025,3,22)),
        new(20,20,new DateTime(2025,3,28)),

        new(21,21,new DateTime(2025,4,2)),
        new(22,22,new DateTime(2025,4,4)),
        new(23,23,new DateTime(2025,4,7)),
        new(24,24,new DateTime(2025,4,10)),
        new(25,25,new DateTime(2025,4,14)),
        new(26,26,new DateTime(2025,4,18)),
        new(27,27,new DateTime(2025,4,22)),
        new(28,28,new DateTime(2025,4,25)),
        new(29,29,new DateTime(2025,5,1)),
        new(30,30,new DateTime(2025,5,3)),
        new(31,31,new DateTime(2025,5,6)),
        new(32,32,new DateTime(2025,5,10)),
        new(33,33,new DateTime(2025,5,14)),
        new(34,34,new DateTime(2025,5,17)),
        new(35,35,new DateTime(2025,5,21)),
        new(36,36,new DateTime(2025,5,25)),
        new(37,37,new DateTime(2025,5,28)),
        new(38,38,new DateTime(2025,6,2)),
        new(39,39,new DateTime(2025,6,6)),
        new(40,40,new DateTime(2025,6,10))
    ];

    public static List<ItemPedido> ItensPedido =
    [
        new(1,1,1,1,4500),
        new(2,1,4,2,180),

        new(3,2,12,1,7600),
        new(4,2,15,1,250),

        new(5,3,21,1,700),
        new(6,3,22,1,1300),

        new(7,4,18,1,4300),
        new(8,4,20,2,390),

        new(9,5,24,1,540),
        new(10,5,25,1,230),

        new(11,6,11,1,4200),
        new(12,6,15,2,250),

        new(13,7,30,1,1800),
        new(14,7,29,2,110),

        new(15,8,27,2,120),
        new(16,8,28,1,220),

        new(17,9,5,1,420),
        new(18,9,8,2,650),

        new(19,10,6,1,980),
        new(20,10,15,1,250),

        new(21,21,2,1,3900),
        new(22,21,5,1,420),
        new(23,21,15,2,250),

        new(24,22,11,1,4200),
        new(25,22,17,1,890),

        new(26,23,24,1,540),
        new(27,23,26,1,760),
        new(28,23,25,2,230),

        new(29,24,30,1,1800),
        new(30,24,29,3,110),

        new(31,25,18,1,4300),
        new(32,25,20,1,390),

        new(33,26,7,2,1450),
        new(34,26,8,1,650),

        new(35,27,13,1,1800),
        new(36,27,15,1,250),
        new(37,27,16,1,480),

        new(38,28,21,1,700),
        new(39,28,23,1,580),

        new(40,29,3,1,3700),
        new(41,29,6,1,980),

        new(42,30,27,3,120),
        new(43,30,28,1,220),

        new(44,31,29,2,110),
        new(45,31,24,1,540),

        new(46,32,12,1,7600),
        new(47,32,15,2,250),

        new(48,33,1,1,4500),
        new(49,33,8,2,650),
        new(50,33,5,1,420),

        new(51,34,30,1,1800),
        new(52,34,17,1,890),

        new(53,35,22,1,1300),
        new(54,35,21,1,700),

        new(55,36,14,1,2100),
        new(56,36,16,2,480),

        new(57,37,10,1,980),
        new(58,37,9,1,520),

        new(59,38,11,1,4200),
        new(60,38,20,2,390),

        new(61,39,18,1,4300),
        new(62,39,15,1,250),

        new(63,40,2,1,3900),
        new(64,40,6,2,980),
        new(65,40,27,2,120)
    ];
}