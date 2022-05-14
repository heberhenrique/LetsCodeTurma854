Console.WriteLine("Bem-vindos a Aula 02");

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


int inteiro = 123;
short abc = 12;
byte b = 255;

/*
byte 	0 ..255
sbyte 	-128 ..127
short 	-32,768 ..32,767
ushort 	0 ..65,535
int 	-2,147,483,648 ..2,147,483,647
uint 	0 ..4,294,967,295
long 	-9,223,372,036,854,775,808..9,223,372,036,854,775,807
ulong 	0 ..18,446,744,073,709,551,615
float 	-3.402823e38 ..3.402823e38
double 	-1.79769313486232e308 ..1.79769313486232e308
decimal -79228162514264337593543950335..79228162514264337593543950335
char 	U+0000 .. U+ffff
*/

long NumCpf = 36857320802;

var salarioTexto = "11234.55";
float salario1 = 11234.55f;
double salario2 = 11234.55;
decimal salario3 = 11234.55m;

int teste = 1233;
long teste2 = teste;

salario3 = (decimal)salario1;
salario3 = Convert.ToDecimal(salarioTexto);

int teste3 = 1233;



Console.ReadLine();

