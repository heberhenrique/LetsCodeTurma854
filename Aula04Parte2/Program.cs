// See https://aka.ms/new-console-template for more information
Console.WriteLine("Aula 04!");

Queue<string> fila = new Queue<string>();
fila.Enqueue("maria"); // <--
fila.Enqueue("joao");
fila.Enqueue("raimundo");
fila.Enqueue("luiza");
fila.Enqueue("pedro");
fila.Enqueue("joel");
var lista = fila.Append("heber").ToList();

var dic = fila.ToDictionary(str => str);

Console.WriteLine($"dicionario primeiro elemento: {dic["maria"]}");
Console.WriteLine($"lista count: {lista.Count}");
Console.WriteLine($"lista ultimo elemento: {lista[lista.Count - 1]}");
Console.WriteLine($"fila count: {fila.Count}");
Console.WriteLine($"Primeiro da fila: {fila.Peek()}");
Console.WriteLine($"Primeiro da fila: {fila.Peek()}");
Console.WriteLine($"Primeiro da fila: {fila.Dequeue()}");
Console.WriteLine($"Primeiro da fila: {fila.Peek()}");

Stack<string> pilha = new Stack<string>();
pilha.Push("prato1");
pilha.Push("prato2");
pilha.Push("prato3");
pilha.Push("prato4");
pilha.Push("prato5");
pilha.Push("prato6");
Console.Clear();
Console.WriteLine(pilha.Peek());
Console.WriteLine(pilha.Pop());

var fila2 = new Queue<string>(pilha.Reverse());
Console.WriteLine(pilha.Peek());
Console.WriteLine(fila2.Peek());

