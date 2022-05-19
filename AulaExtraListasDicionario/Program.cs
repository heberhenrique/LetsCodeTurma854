// See https://aka.ms/new-console-template for more information
using System.Text;

Console.WriteLine("===== Aula Extra ======");
// Dúvidas sobre arquivo e manipulação de arquivos
// Dúvidas sobre array,

// SE
// SENAO
// SENAO SE
// ENQUANTO

// ATRAVESSAR()    <- ACAO
// AGUARDAR()      <- ACAO
// OLHARRUA()      <- ACAO
// OLHARSEMAFORO() <- ACAO
// APERTARBOTAO()  <- ACAO
// SEMAFORO        <- OBJETO / ESTADO
// MOVIMENTORUA    <- OBJETO / ESTADO


// SEMAFORO <= OLHARSEMAFORO()
// SE SEMAFORO ESTIVER VERDE  <-- IF
//    MOVIMENTORUA <= OLHARRUA()
//    (ENQUANTO MOVIMENTORUA IGUAL MOVIMENTADA) <-- WHILE
//         AGUARDAR()
//         MOVIMENTORUA <= OLHARRUA()
//    ATRAVESSAR()
// SENAO                <-- ELSE
//    APERTARBOTAO()
//    AGUARDAR()
//    SEMAFORO <= OLHARSEMAFORO()
//    

// =================================================
// SEMAFORO <= OLHARSEMAFORO()
// (ENQUANTO SEMAFORO IGUAL VERMELHO)
//      SEMAFORO <= OLHARSEMAFORO()
//      AGUARDAR()
//  MOVIMENTORUA <= OLHARRUA()
//  (ENQUANTO MOVIMENTORUA IGUAL MOVIMENTADA) <-- WHILE
//      AGUARDAR()
//      MOVIMENTORUA <= OLHARRUA()
//   ATRAVESSAR()

// =================================
// CONDICIONAIS
// if
// else
// else if
// LAÇOS DE REPETIÇÃO
// foreach <- coleção de dados / finito
// for
// while
// do while

for (; ;)
{
    Console.WriteLine("Olá, Mundo - for sem condição!");
    var input = Console.ReadKey();
    if (input.Key == ConsoleKey.Enter)
        break;
}

while (true)
{
    Console.WriteLine("Olá, Mundo - while!");
    var input = Console.ReadKey();
    if (input.Key == ConsoleKey.Enter)
        break;
}

int count = 0;

while (count < 10)
{
    Console.WriteLine("Olá, Mundo - while!");
    var input = Console.ReadKey();
    if (input.Key == ConsoleKey.Enter)
        break;
    count++;
}

do
{
    Console.WriteLine("Olá, Mundo - do while!");
    var input = Console.ReadKey();
    if (input.Key == ConsoleKey.Enter)
        break;
} while (true);

//for (; ; ) // <- condicionais
//{
//    // sem condição mano
//}

for (int i = 0; i < 10; i++)
{
    Console.WriteLine($"Olá, Mundo - for com {i}!");
}

/// ==============================
/// ARRAY

string[] arrStr;
int[] arrInt;
char[] arrChar;
var ex = "teste".Length;

//foreach (var item in "Heber")
//{

//}

//var arrayAlunos = new string[] { "Heber", "" };
//string[] arrBlaBla = string[10];
string[] arrayProfessores = new string[10];

string[] arrayAlunos = { "Heber", "Mari", "Lucas" };

foreach (var aluno in arrayAlunos)
{
    Console.WriteLine(aluno);
}

//==================================
// SPLIT

var nome = "Heber Henrique da Silva";
var arrNome = nome.Split();
Console.Clear();
foreach (var nomeD in arrNome)
{
    Console.WriteLine(nomeD);
}

Console.ReadKey();

Console.Clear();

Console.WriteLine("quantos patinhos foram passear?");
var qtdPatinhos = Convert.ToInt32(Console.ReadLine());

StringBuilder sb = new StringBuilder();

for (int i = qtdPatinhos; i > 0; i--)
{
    if (i == 1)
        sb.AppendLine($" {i} foi passear alem das montanhas para brincar!");
    else
        sb.AppendLine($" {i} foram passear alem das montanhas para brincar!");

    sb.AppendLine("A mamae gritou qua qua qua qua");

    if (i == 1)
        sb.AppendLine($"mas nenhum patinho voltou de lá");
    else if (i == 2)
        sb.AppendLine($"mas só 1 patinho voltou de lá");
    else
        sb.AppendLine($"mas só {i - 1} patinhos voltaram de lá");
}

Console.WriteLine(sb.ToString());

Console.Clear();

var listaVip = new List<string>();

listaVip.Add("Nat Fontanezi");
listaVip.Add("Marcella Roverato");



foreach (var item in listaVip)
{
    Console.WriteLine(item);
}

Console.WriteLine("************");

var nomeLista = listaVip[0].Split();

foreach (var item in nomeLista)
{
    Console.WriteLine(item);
    listaVip.Add(item);
}

Console.WriteLine("************");

foreach (var item in listaVip)
{
    Console.WriteLine(item);
}

//=========================
Console.Clear();
var dicGrupoAlunos = new Dictionary<string, List<string>>();
var grupo1 = new List<string>();
grupo1.Add("Augustinho");
grupo1.Add("Lucas");
grupo1.Add("Lugan");
var grupo2 = new List<string>();
grupo2.Add("Marcella");
grupo2.Add("Matheus");
grupo2.Add("Robs");
dicGrupoAlunos.Add("Marvel", grupo1);
dicGrupoAlunos.Add("DC Comics", grupo2);

foreach (var grupo in dicGrupoAlunos)
{
    Console.WriteLine(grupo.Key);
    foreach (var aluno in grupo.Value)
    {
        Console.WriteLine(aluno);
    }
}



Console.ReadKey();
Console.Clear();
Console.WriteLine("***********");


foreach (var aluno in dicGrupoAlunos["Marvel"])
{
    Console.WriteLine(aluno);
}