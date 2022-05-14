// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

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

long cpf = 36857320802;

var salarioTexto = "11234.55";
float salario1 = 11234.55f;
double salario2 = 11234.55;
decimal salario3 = 11234.55m;

int teste = 1233;
long teste2 = teste;

salario3 = (decimal)salario1;
salario3 = Convert.ToDecimal(salarioTexto);


