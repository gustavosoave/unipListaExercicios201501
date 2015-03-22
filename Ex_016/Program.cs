using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/*
 * Escreva um algoritmo para imprimir os números de 1 (inclusive) a 10 (inclusive) em ordem crescente.
 */

namespace Ex_016
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Exercicio 16");
            Console.WriteLine("Escreva um algoritmo para imprimir os números de 1 (inclusive) a 10 (inclusive) em ordem crescente.");

            Console.WriteLine("\n=========== Resultado ===========");
            for (int i = 1; i <= 10; i++) {
                Console.Write("{0}", i);
                if (i < 10)
                    Console.Write(", ");
            }


            Console.WriteLine("\n\nPrecione qualquer tecla para sair...");
            Console.ReadKey();
        }
    }
}
