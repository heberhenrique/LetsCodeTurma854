// See https://aka.ms/new-console-template for more information
Console.WriteLine("=== Aula 05 - resolução exercicio ===");


var texto1 = "Paralelepipedo";
Console.WriteLine(texto1.Substring(6)); // <-- lepipedo
Console.WriteLine(texto1.Substring(6, 3)); // <-- lep

Console.Clear();

var needle1 = "Safra";
var haystack1 = "Banco Safra";
//Console.WriteLine(StrStr(haystack1, needle1)); // <-- chamando função

var needle2 = "pedo";
var haystack2 = "Paralelepipedo";
Console.WriteLine(StrStr(haystack2, needle2));

var needle3 = "bla";
var haystack3 = "Paralelepipedo";
//Console.WriteLine(StrStr(haystack3, needle3));

var needle4 = "";
var haystack4 = "Paralelepipedo";
//Console.WriteLine(StrStr(haystack4, needle4));

/// <summary>
/// Dada a variavel 'needle' descubra se existe o valor dessa variavel
/// na variavel 'haystack' e retorne a posicao inicial de onde a palavra se inicia
/// </summary>
static int StrStr(string haystack, string needle)
{
    if (string.IsNullOrEmpty(needle))
        return 0;

    var lowerNeedle = needle.ToLower();
    var lowerHaystack = haystack.ToLower();

    if (lowerHaystack.Contains(lowerNeedle))
    {
        //return lowerHaystack.IndexOf(lowerNeedle);
        //IndexOf faz tudo isso que a gente fez abaixo
        var indexHaystack = 0;
        var tamanhoPalavra = lowerNeedle.Length;
        for (int i = 0; i < lowerHaystack.Length; i++)
        {
            if (lowerHaystack[i] == lowerNeedle[0])
            {
                var stringToCompare = lowerHaystack.Substring(i, tamanhoPalavra);
                Console.WriteLine($"Letra: {lowerHaystack[i]}");
                Console.WriteLine($"Resultado Substring: {stringToCompare}");

                if (stringToCompare == lowerNeedle)
                {
                    // adicionar a lista 
                    indexHaystack = i;
                    break; // remover
                }
            }
        }
        return indexHaystack;
    }
    else
        return -1;
}

static int StrStr2(string haystack, string needle)
{
    if (string.IsNullOrEmpty(needle))
        return 0;

    var lowerNeedle = needle.ToLower();
    var lowerHaystack = haystack.ToLower();

    if (lowerHaystack.Contains(lowerNeedle))
    {
        //return lowerHaystack.IndexOf(lowerNeedle);
        var charNeddle = lowerNeedle[0];
        var indexHaystack = 0;
        for (int i = 0; i < lowerHaystack.Length; i++)
        {
            if (lowerHaystack[i] == charNeddle)
            {
                indexHaystack = i;
                break;
            }
        }
        return indexHaystack;
    }
    else
        return -1;
}
