using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/*
 * Reescreva o exercício 17 utilizando a estrutura ENQUANTO e um CONTADOR.
 */

namespace Ex_023
{
    class Program
    {
        static void Main(string[] args)
        {
            int contador = 10;

            Console.WriteLine("Exercicio 23");
            Console.WriteLine("Reescreva o exercício 17 utilizando a estrutura ENQUANTO e um CONTADOR.");

            Console.WriteLine("\n=========== Resultado ===========");

            while (contador > 0) {
                
                Console.Write(contador);
                
                if (contador > 1)
                    Console.Write(", ");

                contador--;
            }


            Console.WriteLine("\n\nPrecione qualquer tecla para sair...");
            Console.ReadKey();
        }
    }
}
