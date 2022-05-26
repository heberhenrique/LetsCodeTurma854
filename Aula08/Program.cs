// See https://aka.ms/new-console-template for more information
Console.WriteLine("===== Aula 08 =====");
// =>
(string Nome, DateTime DataNascimento) cliente1 = ("Henrique", new DateTime(1988, 8, 21));
(string Nome, DateTime DataNascimento) cliente2 = ("João", new DateTime(1998, 8, 21));
(string Nome, DateTime DataNascimento) cliente3 = ("Maria", new DateTime(1978, 8, 21));
(string Nome, DateTime DataNascimento) cliente4 = ("Luana", new DateTime(2000, 8, 21));
(string Nome, DateTime DataNascimento) cliente5 = ("Henrique", new DateTime(1988, 8, 21));
List<(string Nome, DateTime DataNascimento)> listaClientes = new List<(string Nome, DateTime DataNascimento)>();

listaClientes.Add(cliente1);
listaClientes.Add(cliente2);
listaClientes.Add(cliente3);
listaClientes.Add(cliente4);
listaClientes.Add(cliente5);

var retorno = listaClientes.Find(cliente => cliente.Nome == "Henrique");

Console.WriteLine($"Retorno do Find: {retorno}");

retorno = listaClientes.Find(cliente => cliente.Nome == "Heber");

var retornoLinq = listaClientes.Where(cliente => cliente.Nome.Contains("a"));

foreach (var item in retornoLinq)
{
    Console.WriteLine($"Retorno do Linq: {item}");
}

var listaInt = new List<int>();

for (int i = 0; i < 10; i++)
{
    var random = new Random();
    var num = random.Next(999);
    Console.WriteLine($"Num: {num}");

    listaInt.Add(num);
}

Console.WriteLine("----------------------");
Console.WriteLine($"Total: {listaInt.Sum()}");

Console.WriteLine("----------------------");
var minhasContas = new List<(string Banco, double Saldo)>();
minhasContas.Add(("Bradesco", 150));
minhasContas.Add(("Safra", 150));
minhasContas.Add(("Itau", 150));
minhasContas.Add(("XP", 150));
minhasContas.Add(("Modal", 150));
Console.WriteLine("----------------------");
Console.WriteLine($"Total Contas:{minhasContas.Sum(mc => mc.Saldo)}");


var mediaIdade = listaClientes.Average(cliente => (DateTime.Now.Year - cliente.DataNascimento.Year));
Console.WriteLine($"Media Idade: {mediaIdade}");

foreach (var item in listaClientes)
{
    Console.WriteLine(item.Nome);
}

Console.WriteLine("----------------------");

var newListaCliente = listaClientes.DistinctBy(c => c.Nome);

foreach (var item in newListaCliente)
{
    Console.WriteLine(item.Nome);
}

(string Nome, DateTime DataNascimento) test1 = ("Henrique", new DateTime(1988, 8, 21));
var test2 = ("Henrique", new DateTime(1988, 8, 21));

Console.WriteLine(test1.GetType());
Console.WriteLine(test2.GetType());


string texto6 = $@"
    SELECT
          NOME
        , IDADE
        , PROFISSAO
        , CPF
        , RG
        , ENDERECO
    FROM
        FUNCIONARIOS
    WHERE
        NOME = 'XPTO'";

int[] numbers = new int[7] { 5, 3, 2, 1, 4, 0, 6 };

var numQuery =
    from num in numbers
    where (num % 2) == 0
    select num;

foreach (int num in numQuery)
{
    Console.Write("{0,1} ", num);
}

Console.WriteLine();
Console.WriteLine("----------------------");

var numQuery2 =
    from num in numbers
    orderby num descending
    select num;

foreach (int num in numQuery2)
{
    Console.Write("{0,1} ", num);
}

Console.WriteLine();
Console.WriteLine("----------------------");

numbers.ToList().Sort();

var listaNum = numbers.ToList();

foreach (int num in listaNum)
{
    Console.Write("{0,1} ", num);
}

Console.WriteLine();
Console.WriteLine("----------------------");

listaNum.Sort();
listaNum.Reverse();

foreach (var item in listaNum)
{
    Console.Write("{0,1} ", item);
}

listaNum.RemoveAll(n => n % 2 == 0);

Console.WriteLine();
Console.WriteLine("----------------------");

foreach (var item in listaNum)
{
    Console.Write("{0,1} ", item);
}

listaNum.Clear();