using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/*
 * Ler um valor N e imprimir todos os valores inteiros entre 1 (inclusive) e N (inclusive). Considere que o N será sempre maior que ZERO.
 */

namespace Ex_019
{
    class Program
    {
        static void Main(string[] args)
        {
            int max;

            Console.WriteLine("Exercicio 19");
            Console.Write("Entre o numero a ser contado : ");
            max = int.Parse(Console.ReadLine());


            Console.WriteLine("\n=========== Resultado ===========");
            for (int i = 1; i <= max; i++)
            {
                Console.Write("{0}", i);
                
                if (i < max)
                    Console.Write(", ");

                if (i % 10 == 0)
                    Console.Write("\n");
            }


            Console.WriteLine("\n\nPrecione qualquer tecla para sair...");
            Console.ReadKey();
        }
    }
}
