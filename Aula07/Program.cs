// See https://aka.ms/new-console-template for more information
Console.WriteLine("==== Aula 07 ====");

int[] arrInt = { 1, 2, 3 };

int[][] arrayDeAarray = new int[5][];
arrayDeAarray[0] = arrInt;

int[][][] arrayDarrayDarray = new int[5][][];
arrayDarrayDarray[0] = arrayDeAarray;

int[] arraySimples = { 4, 5, 6 };
string[,] jogoDaVelha = new string[3, 3];

// primeira posição linha, segunda posição coluna (X, Y)
jogoDaVelha[0, 0] = "O";
jogoDaVelha[0, 1] = "X";
jogoDaVelha[0, 2] = "X";
jogoDaVelha[1, 0] = " ";
jogoDaVelha[1, 1] = "X";
jogoDaVelha[1, 2] = " ";
jogoDaVelha[2, 0] = "O";
jogoDaVelha[2, 1] = "O";
jogoDaVelha[2, 2] = " ";

string[, ,] cubo = new string[3, 3, 3];

Console.WriteLine($"Tamanho matriz: {jogoDaVelha.Length}");

foreach (var item in jogoDaVelha)
{
    Console.WriteLine(item);
}

var linha = jogoDaVelha.GetLength(0);
var coluna = jogoDaVelha.GetLength(1);

for (int i = 0; i < linha; i++)
{
    for (int j = 0; j < coluna; j++)
    {
        Console.Write($"{jogoDaVelha[i, j]} ");
    }
    Console.WriteLine();
}

byte[] arrInt2 = new byte[3];

byte b1 = 255;
byte[] arrBytes = { b1, b1, b1 };
byte[] arrBytes2 = { b1, b1, b1, b1 };

byte[,][] pixels = new byte[10, 10][];

byte[,,][] pixels3d = new byte[10, 10, 10][];

pixels[0, 0] = arrBytes;
pixels[0, 1] = arrBytes2;








