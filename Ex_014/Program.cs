using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/*
 * Ler dois valores (considere que não serão lidos valores iguais) e escrevê- los em ordem crescente.
 */

namespace Ex_014
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numeros = new int[2];

            Console.WriteLine("Exercicio 14");

            Console.Write("\nEntre com o primeiro valor : ");
            numeros[0] = int.Parse(Console.ReadLine());
            Console.Write("Entre com o segundo valor : ");
            numeros[1] = int.Parse(Console.ReadLine());

            Array.Sort(numeros);

            Console.WriteLine("\n=========== Resultado ===========");
            Console.WriteLine("\nValores Ordenados :\n{0}\n{1}", numeros[0], numeros[1]);

            Console.WriteLine("\n\nPrecione qualquer tecla para sair...");
            Console.ReadKey();
        }
    }
}
