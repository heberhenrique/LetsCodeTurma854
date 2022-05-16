// See https://aka.ms/new-console-template for more information
using System.Globalization;
using System.Text;

Console.WriteLine("Aula 04");

/*
 Desafio

Parte - 1

Dada a lista de empresas no arquivo .csv armazene em um dicionário as mesmas agrupando por setor, ou seja, todas as empresas do tipo varejo devem estar na chave "varejo".

Parte - 2

Quando eu digitar alguma coisa o programa deve validar se a chave existe e caso exista deve exibir o ticker da empresa (código) e o seu nome. Exemplo:

Entrada => Elétrica
Saída     => AESB3 - Aes Brasil

Parte 3

O programa não deve diferenciar letras maiúsculas de letras minúsculas e nem caracteres especiais. Exemplo:

Entrada => Saude
Saída => RDOR3 - Rede Dor São Luiz S.A
 */

var arquivo = File.ReadAllLines("/users/heberhenriquedasilva/desktop/empresas.csv");
var dicEmpresas = new Dictionary<string, List<string>>();
var terminarPrograma = false;


for (int i = 1; i < arquivo.Length; i++)
{
    var nome = arquivo[i].Split(';')[0];
    var setor = arquivo[i].Split(';')[1];
    var codigo = arquivo[i].Split(';')[2];

    if (!string.IsNullOrWhiteSpace(nome) &&
        !string.IsNullOrWhiteSpace(setor) &&
        !string.IsNullOrWhiteSpace(codigo))
    {
        var setorNorm = RemoverAcentuacao(setor).ToLower().Trim();

        if (!dicEmpresas.ContainsKey(setorNorm))
        {
            
            dicEmpresas.Add(setorNorm, new List<string>() { $"{codigo} - {nome}" });
        }
        else
        {
            dicEmpresas[setorNorm].Add($"{codigo} - {nome}");
        }
    }
}

const string comandoEncerrar = "sair";
while (!terminarPrograma)
{
    Console.WriteLine("Digite o setor da empresa ou digite sair para encerrar o programa");
    var inputSetorRaw = Console.ReadLine();
    var inputSetor = inputSetorRaw.ToLower().Trim();

    //if (comandoEncerrar == inputSetor)
    //{
    //    terminarPrograma = true;
    //}

    if (comandoEncerrar.Equals(inputSetorRaw, StringComparison.InvariantCultureIgnoreCase))
        break;

    if (string.IsNullOrWhiteSpace(inputSetor))
        Console.WriteLine("Setor Inválido! Digite novamente");


    var setorStr = RemoverAcentuacao(inputSetor);

    //dicEmpresas.Where(keyValuePair => RemoverAcentuacao(keyValuePair.Key).Equals(setorStr));

    if (dicEmpresas.ContainsKey(setorStr))
    {
        var listaEmpresas = dicEmpresas[setorStr];
        foreach (var empresa in listaEmpresas)
        {
            Console.WriteLine(empresa);
        }
    }
    else
    {
        Console.WriteLine("Setor não encontrado! digite qualquer tecla para continuar.");
    }
    
    Console.Read();
    Console.Clear();
}


string RemoverAcentuacao2(string text)
{
    var newChars = new List<char>();
    foreach (var caractere in text)
    {
        //if(char.GetUnicodeCategory(caractere) != UnicodeCategory.NonSpacingMark)
        //{
        //    newChars.Add(caractere);
        //}

        if (caractere.Equals('ç'))
        {
            newChars.Add(caractere);
        }
    }

    var textoFormatado = new string(newChars.ToArray());

    var textoFormatado2 = new string(text.Where(ch => ch.Equals('ç')).ToArray());

    //var textoFormatado2 = new string(text.Normalize(NormalizationForm.FormD)
    //    .Where(caractere => char.GetUnicodeCategory(caractere) != UnicodeCategory.NonSpacingMark)
    //    .ToArray());

    return textoFormatado2;
}

string RemoverAcentuacao(string text)
{
    return new string(text.Normalize(NormalizationForm.FormD)
        .Where(caractere => char.GetUnicodeCategory(caractere) != UnicodeCategory.NonSpacingMark)
        .ToArray());
}



