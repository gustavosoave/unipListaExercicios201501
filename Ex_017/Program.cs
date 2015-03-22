using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/*
 * Escreva um algoritmo para imprimir os números de 1 (inclusive) a 10 (inclusive) em ordem decrescente.
 */

namespace Ex_017
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Exercicio 17");
            Console.WriteLine("Escreva um algoritmo para imprimir os números de 1 (inclusive) a 10 (inclusive) em ordem decrescente.");

            Console.WriteLine("\n=========== Resultado ===========");
            for (int i = 10; i > 0; i--)
            {
                Console.Write("{0}", i);
                if (i > 1)
                    Console.Write(", ");
            }


            Console.WriteLine("\n\nPrecione qualquer tecla para sair...");
            Console.ReadKey();
        }
    }
}
