using System;

namespace Aula05MetodosNet5
{
    class Program
    {
        // atributos (field)
        // construtores / main
        // metodos

        static string _cabecalho = "Aula 05";

        // Estrutura de um método
        // modificadores de acesso // public/protected/internal/private
        // modicadores de comportamento
        // <modicadores de comportamento><tipo de retorno> <nome do metodo><assinatura do metodo>
        // Tipo de retorno => oq o metodo vai retornar
        // Nome do metodo => nome da funcao que pode descrever o objetivo deste metodo
        // assinatura do metodo => parametros que o metodo pode receber
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("Digite um Numero");
            var numero1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite outro Numero");
            var numero2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"[{_cabecalho}]Resultado da soma: {Somar(numero1, numero2)}");
        }

        static int Somar(int num1, int num2)
        {
            return num1 + num2;
        }

        
    }
}

