// See https://aka.ms/new-console-template for more information
Console.WriteLine("AULA 02");

string texto = "exemplo:";
string nome = "Heber Silva";
//char texto2 = ""; // string.Empty
string texto3 = string.Empty;
char texto4 = '\u0033';
string texto5 = "Heber\nSilva";
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
        NOME = {nome}";
//texto4 = 'b' + 'a';

string arquivo = @"heber silva; 11982632463 ; heberhenrique@gmail.com";
string cpf = "724.374.410-93";

string telefone = arquivo.Split(';')[1];
string[] arquivoArray = arquivo.Split(';');

// Remove(posicao inicial, qtdCaracteres a serem removidos)
// 0 = posicao inicial da string
// 5 = qtd de carac a serem removidos

//Replace(caractere a ser removido, caractere que vai no lugar)
//Console.WriteLine(cpf.Replace(".","").Replace("-", ""));

int[] arrayTaina = new int[6];
int[] arrayTaina2 = { 12, 13, 14 };

arrayTaina[3] = 55;

Console.WriteLine(arrayTaina2[2]);

Console.WriteLine(nome.Remove(0, 6)); // Silva
Console.WriteLine(nome.Substring(0, 6)); //Heber .

string nome2 = "maRcO antonio batista dE souza";

var arrayNome2 = nome2.Split(' ');



Console.WriteLine(arrayNome2[2]);












Console.Read();




