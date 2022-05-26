using System.Runtime.InteropServices;
using System.Security.AccessControl;
using System.Text;
using System.Text.Json;

Console.WriteLine("=====Aula 05!=======");
// structs
// metod
// Serialization
// Json
// testes
// tratamento de exceção
const string caminhoArquivo = $"/users/heberhenriquedasilva/desktop/cliente.txt";

var cliente = new DadosCliente();
cliente.Nome = "Heber Henrique da Silva";
cliente.DataNascimento = new DateTime(1988,8,21);
cliente.EstadoCivil = EstadoCivil.Solteiro;
cliente.Cpf = "388.241.050-76";

var jsonStr = JsonSerializer.Serialize(cliente);

using (var file = File.Open(caminhoArquivo, FileMode.OpenOrCreate))
{
    byte[] dados = new UTF8Encoding(true).GetBytes(jsonStr);
    file.Write(dados, 0, dados.Length);

    file.Flush();
}

var fileStr = File.ReadAllText(caminhoArquivo);

var novoCliente = JsonSerializer.Deserialize<DadosCliente>(fileStr);

Console.WriteLine(Marshal.SizeOf(novoCliente));
Console.WriteLine(Marshal.SizeOf(new DadosCliente()));
Console.WriteLine(Marshal.SizeOf(new DadosEmpresa()));
Console.WriteLine(Marshal.SizeOf(new DadosEmpresaBolsa()));

Console.WriteLine($"Nome cliente: {novoCliente.Nome}");
Console.WriteLine($"Data de Nascimento: {novoCliente.DataNascimento}");
Console.WriteLine($"Estado Civil: {novoCliente.EstadoCivil}");
Console.WriteLine($"Cpf: {novoCliente.Cpf}");

var num1 = "123";
int ret;

var sucesso = int.TryParse(num1, out ret);

if (sucesso)
{
    Console.WriteLine(ret);
}

Tuple<string, DateTime> cliente4 = new Tuple<string, DateTime>("Henrique", new DateTime(1988, 8, 21));

(string Nome, DateTime DataNascimento) cliente2 = ("Henrique", new DateTime(1988, 8, 21));
var teste = ("Henrique", new DateTime(1988, 8, 21));

(
    string Nome,
    DateTime DataNascimento,
    string Cpf,
    string Endereco,
    char Sexo,
    string Nacionalidade
)
cliente3 =
(
    "Joao",
    new DateTime(1988, 8, 21),
    "",
    "",
    'M',
    "Brasileiro"
);

var listaTupla = new List<(string Nome, DateTime DataNascimento)>();
listaTupla.Add(("Silva", new DateTime(1988, 8, 21)));

//ObjectCache cache = MemoryCache.Default;
Console.ForegroundColor = ConsoleColor.Black;
Console.BackgroundColor = ConsoleColor.DarkYellow;

PrintLine();
PrintRow("Nome", "Data Nascimento", "Estado Civil", "CPF");
PrintLine();
PrintRow($"{novoCliente.Nome}", $"{novoCliente.DataNascimento:dd/MM/yyyy}", $"{novoCliente.EstadoCivil}", $"{novoCliente.Cpf}");
PrintRow($"", $"", $"", $"");
PrintLine();

Console.ForegroundColor = ConsoleColor.White;
Console.BackgroundColor = ConsoleColor.DarkBlue;

PrintLine();
PrintRow("Nome", "Data Nascimento", "Estado Civil", "CPF");
PrintLine();
PrintRow($"{novoCliente.Nome}", $"{novoCliente.DataNascimento:dd/MM/yyyy}", $"{novoCliente.EstadoCivil}", $"{novoCliente.Cpf}");
PrintRow($"", $"", $"", $"");
PrintLine();

Console.ForegroundColor = ConsoleColor.White;
Console.BackgroundColor = ConsoleColor.Red;

PrintLine();
PrintRow("Nome", "Data Nascimento", "Estado Civil", "CPF");
PrintLine();
PrintRow($"{novoCliente.Nome}", $"{novoCliente.DataNascimento:dd/MM/yyyy}", $"{novoCliente.EstadoCivil}", $"{novoCliente.Cpf}");
Console.BackgroundColor = ConsoleColor.DarkCyan;
PrintRow($"", $"", $"", $"");
Console.BackgroundColor = ConsoleColor.Red;
PrintLine();
Console.ReadLine();


static void PrintLine()
{
    Console.WriteLine(new string('-', 73));
}

static void PrintRow(params string[] columns)
{
    int width = (73 - columns.Length) / columns.Length;
    string row = "|";

    foreach (string column in columns)
    {
        row += AlignCentre(column, width) + "|";
    }

    Console.WriteLine(row);
}

static string AlignCentre(string text, int width)
{
    text = text.Length > width ? text.Substring(0, width - 3) + "..." : text;

    if (string.IsNullOrEmpty(text))
    {
        return new string(' ', width);
    }
    else
    {
        return text.PadRight(width - (width - text.Length) / 2).PadLeft(width);
    }
}

public struct DadosCliente
{
    public string Nome { get; set; }
    public DateTime DataNascimento { get; set; }
    public EstadoCivil EstadoCivil { get; set; }
    public string Cpf { get; set; }
}

public struct DadosEmpresa
{
    public string Nome { get; set; }
    public long Cnpj { get; set; }
}

public struct DadosEmpresaBolsa
{
    public string Nome { get; set; }
    public string Codigo { get; set; }
}

public struct RepositorioCliente
{
    public bool Salvar(DadosCliente cliente)
    {
        return false;
    }

    public void Salvar(List<DadosCliente> cliente)
    {
    }
}

public enum EstadoCivil
{
    Solteiro,
    Casado,
    Divorciado,
    Viuvo,
}