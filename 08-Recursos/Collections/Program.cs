// List lista ordenada que pode crescer
List<string> nomes = new();
nomes.Add("John");
nomes.Add("João");
nomes.Add("Johan");
nomes.Remove("João");
nomes.RemoveAt(0);
bool contem = nomes.Contains("Johan");
Console.WriteLine(contem + " | " + nomes[0]);

// HashSet Saber rapidamente se existe um elemento e evitar duplicados
HashSet<string> usuarios = new();
usuarios.Add("John");
usuarios.Add("João");
usuarios.Add("Johan");
contem = usuarios.Contains("João");
Console.WriteLine(contem);

// Dictionary encontrar um valor a partir de uma chave
Dictionary<string, string> telefones = new();

telefones.Add("John", "99999-9999");
telefones.Add("Maria", "88888-8888");
Console.WriteLine(telefones["John"]);

// Queue FIFO
Queue<string> fila = new();

fila.Enqueue("João");
fila.Enqueue("Maria");
fila.Enqueue("Pedro");
string atendido = fila.Dequeue();
string proximo = fila.Peek();
Console.WriteLine(atendido + "| Proximo: " + proximo);
atendido = fila.Dequeue();
proximo = fila.Peek();
Console.WriteLine(atendido + "| Proximo: " + proximo);

// Stack LIFO
Stack<string> pilha = new();

pilha.Push("Livro 1");
pilha.Push("Livro 2");
pilha.Push("Livro 3");
string livro = pilha.Pop();
string proximoLivro = pilha.Peek();
Console.WriteLine(livro + "| Proximo: " + proximoLivro);
livro = pilha.Pop();
proximoLivro = pilha.Peek();
Console.WriteLine(livro + "| Proximo: " + proximoLivro);

// LinkedList<T>