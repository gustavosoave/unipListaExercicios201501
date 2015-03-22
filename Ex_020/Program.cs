using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/*
 * Modifique o exercício anterior para aceitar somente valores maiores que 0
 * para N. Caso o valor informado (para N) não seja maior que 0, deverá ser
 * lido um novo valor para N.
 */

namespace Ex_020
{
    class Program
    {
        static void Main(string[] args)
        {
            int max = 0;

            do
            {
                Console.Clear();
                Console.WriteLine("Exercicio 20");
                Console.Write("Entre o numero a ser contado : ");
                max = int.Parse(Console.ReadLine());

                if (max <= 0) {
                    Console.WriteLine("O valor deve ser MAIOR que 0!!");
                    Console.ReadKey();
                }

            } while (max <= 0);
            
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
