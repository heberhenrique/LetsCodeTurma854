// See https://aka.ms/new-console-template for more information
using System.Collections;

Console.WriteLine("=== Aula 06 - Resolução do exercício ===");

var output = Generate(5);


foreach (var numeros in output)
{
    foreach (var numero in numeros)
    {
        Console.Write($"{numero} ");
    }
    Console.WriteLine();
}

static IList<IList<int>> Generate(int numRows)
{
    IList<IList<int>> response = new List<IList<int>>();
    int[] array;

    if (numRows < 1)
        throw new ArgumentException(null, nameof(numRows));

    if (numRows > 30)
        throw new ArgumentException(null, nameof(numRows));

    for (int i = 0; i < numRows; i++)
    {
        array = new int[i + 1];

        for (int j = 0; j < array.Length; j++)
        {
            if(j == 0 || j == array.Length - 1)
                array[j] = 1;

            if (i > 1 && (j > 0 && j < array.Length - 1))
            {
                var listaAnt = response[i - 1];
                array[j] = listaAnt[j] + listaAnt[j - 1];
            }
        }

        response.Add(array.ToList());
    }

    return response;
}
