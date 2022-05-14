using System.Globalization;

Console.WriteLine("========= Aula 03! Aritmética Computacional e Funções Básicas =========");

// & - AND 
// | - OR
// ˆ - XOR - EXCLUSIVE OR

// NOT

// TRUE & TRUE   = TRUE
// TRUE & FALSE  = FALSE
// FALSE & FALSE = FALSE
// FALSE & TRUE = FALSE
// FALSE && TRUE = FALSE

// TRUE | FALSE  = TRUE
// TRUE | TRUE   = TRUE
// FALSE | FALSE = FALSE

// FALSE ˆ FALSE = FALSE
// TRUE ˆ TRUE   = FALSE
// FALSE ˆ TRUE  = TRUE

bool possuiContaPremium = true;
bool possuiContaBasica = true;
bool possuiContaPrivate = false;

// ==============================
const string pastaArquivos = "Arquivos";
const string caminhoArquivo = $"{pastaArquivos}/text.csv";
const string arquivoEmpresas = $"{pastaArquivos}/empresas.csv";

// Criando Pasta
Directory.CreateDirectory(pastaArquivos);

//Criar arquivo
//using (File.Create(caminhoArquivo))
//{
//}
File.Create(caminhoArquivo).Dispose();

// Ler arquivo
string[] conteudoArquivo = File.ReadAllLines(caminhoArquivo);
string retorno = File.ReadAllText(caminhoArquivo);

Console.WriteLine($"Arquivo criado? => {File.Exists(caminhoArquivo)}");

Console.WriteLine($"Arquivo empresas existe? => {File.Exists(arquivoEmpresas)}");
string retArqEmpresas = File.ReadAllText(arquivoEmpresas);
string[] retArqEmpresas2 = File.ReadAllLines(arquivoEmpresas);
Console.WriteLine();
//Console.WriteLine(retArqEmpresas);
//Console.WriteLine(retArqEmpresas2);

// new() => nova forma de criar objetos no C# 9.0
List<string> listaNomeEmpresas = new();

// retArqEmpresas2 => string[] array de string
// nome da empresa está no indice 0

// TIRANDO O CABEÇALHO COM FOREACH
/*int cabecalho = 0;
foreach (var linha in retArqEmpresas2)
{
    if (cabecalho > 0)
    {
        var colunas = linha.Split(';');
        listaNomeEmpresas.Add(colunas[0]);
    }
    else
        cabecalho++;
}*/

// TIRANDO O CABEÇALHO COM FOR
for (int i = 1; i < retArqEmpresas2.Length; i++)
{
    var colunas = retArqEmpresas2[i].Split(';');
    listaNomeEmpresas.Add(colunas[0]);
}

Console.WriteLine(true ^ true ^ false);

Console.WriteLine($"NOME EMPRESA: {listaNomeEmpresas.ToString()}");
Console.WriteLine($"NOME EMPRESA: {listaNomeEmpresas[0]}");

double salario = 5000.00;

Console.WriteLine($"SALARIO DEV: {salario.ToString("C")}");
Console.WriteLine($"SALARIO DEV: {salario - 1000:C}");
Console.WriteLine($"QUE HORAS SAO {DateTime.Now}");

Console.WriteLine($"QUE HORAS SAO FORMATADO: {DateTime.Now.ToString("dd/MM/yyyy")}");
Console.WriteLine($"QUE HORAS SAO FORMATADO: {DateTime.Now:dd/MM/yyyy}");
Console.WriteLine($"QUE HORAS SAO FORMATADO: {DateTime.Now:dd/MM/yyyy HH:mm}");
Console.WriteLine($"QUE HORAS SAO FORMATADO: {DateTime.Now:U}");
Console.WriteLine($"QUE HORAS SAO FORMATADO: {DateTime.Now.ToString("F", CultureInfo.GetCultureInfo("pt-BR"))}");

Console.Clear();

Console.WriteLine("===== Preenchendo o arquivo =====");

// nome empresa e codigo empresa
var dicEmpresas = new Dictionary<string, int>();
listaNomeEmpresas.Add("LetsCode");
listaNomeEmpresas.Add("Safra");

int codigoEmpresa = 1;

foreach (var item in listaNomeEmpresas)
{
    //dicEmpresas.Add(item, codigoEmpresa);
    codigoEmpresa++;
}

var empresasDaBolsa = new Dictionary<string, string>();

for (int i = 1; i < retArqEmpresas2.Length; i++)
{
    var colunas = retArqEmpresas2[i].Split(';');
    var nome = colunas[0];
    var codigo = colunas[2];

    

    if(!string.IsNullOrWhiteSpace(codigo) && !empresasDaBolsa.ContainsKey(codigo))
        empresasDaBolsa.Add(codigo, $"{nome} => adicionada as: {DateTime.Now}");
}

Console.WriteLine(empresasDaBolsa["CASH3"]);

var empresasDaBolsa2 = new Dictionary<string, List<string>>();

for (int i = 1; i < retArqEmpresas2.Length; i++)
{
    var colunas = retArqEmpresas2[i].Split(';');
    var nome = colunas[0];
    var codigo = colunas[2];

    if (!string.IsNullOrWhiteSpace(codigo) && !empresasDaBolsa.ContainsKey(codigo))
        empresasDaBolsa.Add(codigo, $"{nome} => adicionada as: {DateTime.Now}");
}


//empresasDaBolsa2["varejo"]







