using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/*
 * Escreva um algoritmo que calcule e imprima a tabuada do 8 (1 a 10)
 */

namespace Ex_021
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Exercicio 21");
            Console.WriteLine("Escreva um algoritmo que calcule e imprima a tabuada do 8 (1 a 10)");

            Console.WriteLine("\n=========== Resultado ===========");
            for (int i = 1; i <= 10; i++) {
                Console.WriteLine("8 x {0} = {1}", i, 8 * i);
            }

            Console.WriteLine("\n\nPrecione qualquer tecla para sair...");
            Console.ReadKey();
        }
    }
}
