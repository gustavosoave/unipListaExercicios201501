using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/*
 * Escreva um algoritmo para ler 10 números e ao final da leitura escrever a soma total dos 10 números lidos
 */

namespace Ex_028
{
    class Program
    {
        static void Main(string[] args)
        {
            double total = 0;

            Console.WriteLine("Exercicio 28");

            for (int i = 0; i < 10; i++) {
                Console.Write("Entre com o {0}º valor : ", i + 1);
                total += double.Parse(Console.ReadLine());
            }


            Console.WriteLine("\n=========== Resultado ===========");

            Console.WriteLine("\nA soma dos valores entrados é de {0}", total);

            Console.WriteLine("\n");

            Console.WriteLine("\n\nPrecione qualquer tecla para sair...");
            Console.ReadKey();
        }
    }
}
