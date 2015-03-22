using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/*
 * Escreva um algoritmo para imprimir os 10 primeiros números inteiros maiores que 100
 */

namespace Ex_018
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Exercicio 18");
            Console.WriteLine("Escreva um algoritmo para imprimir os 10 primeiros números inteiros maiores que 100.");

            Console.WriteLine("\n=========== Resultado ===========");
            for (int i = 100; i <= 110; i++)
            {
                Console.Write("{0}", i);
                if (i < 110)
                    Console.Write(", ");
            }


            Console.WriteLine("\n\nPrecione qualquer tecla para sair...");
            Console.ReadKey();
        }
    }
}
