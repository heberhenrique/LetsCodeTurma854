// See https://aka.ms/new-console-template for more information
using System.Text.RegularExpressions;

Console.WriteLine("=== Aula 06 - Resolução do exercicio ===");

var numeroValido = "MCMXCIV"; //1994
var numeroValido2 = "IV"; // 4
var numeroValido3 = "VIII";
var numeroInvalido = "LLVV";

Console.WriteLine(RomanToInt(numeroValido3));
Console.WriteLine(RomanToInt2(numeroInvalido));


static int RomanToInt(string s)
{
    var numero = 0;
    var algarismos = new Dictionary<char, int>();
    algarismos.Add('I', 1);
    algarismos.Add('V', 5);
    algarismos.Add('X', 10);
    algarismos.Add('L', 50);
    algarismos.Add('C', 100);
    algarismos.Add('D', 500);
    algarismos.Add('M', 1000);

    var pattern = @"\bM{0,4}(CM|CD|D?C{0,3})(XC|XL|L?X{0,3})(IX|IV|V?I{0,3})\b";
    Regex regex = new Regex(pattern);

    if (string.IsNullOrWhiteSpace(s))
        throw new ArgumentException(null, nameof(s));

    if (!regex.Match(s).Success)
        throw new ArgumentException("Número inválido", nameof(s));

    for (int i = 0; i < s.Length; i++)
    {
        var valorAtual = algarismos[s[i]];
        var proximoValor = 0;

        if (i + 1 < s.Length)
            proximoValor = algarismos[s[i + 1]];

        if (valorAtual < proximoValor)
        {
            numero += proximoValor - valorAtual;
            i++;
        }
        else
        {
            numero += valorAtual;
        }
    }

    return numero;
}

static int RomanToInt2(string s)
{
    Dictionary<char, int> symbols = new Dictionary<char, int>() { { 'I', 1 }, { 'V', 5 }, { 'X', 10 }, { 'L', 50 }, { 'C', 100 }, { 'D', 500 }, { 'M', 1000 } };

    char[] sArray = s.ToArray();

    if (sArray.All(symbols.ContainsKey))
    {

        int res = symbols[sArray[sArray.Length - 1]];

        for (int i = sArray.Length - 2; i >= 0; i--)
        {
            if (symbols[sArray[i]] < symbols[sArray[i + 1]])
            {
                res -= symbols[sArray[i]];
            }
            else
            {
                res += symbols[sArray[i]];
            }
        }
        return res;
    }
    return -1;
}

enum Romans
{
    I = 1,
    V = 5,
    X = 10,
    L = 50,
    C = 100,
    D = 500,
    M = 1000,
}