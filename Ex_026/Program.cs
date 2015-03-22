using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/*
 * Ler 10 valores, calcular e escrever a média aritmética desses valores lidos.
 */

namespace Ex_026
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] valores = new int[10];
            int total = 0;

            Console.WriteLine("Exercicio 26");

            for (int i = 0; i < 10; i++) {
                Console.Write("Entre com o {0}º numero : ", i + 1);
                valores[i] = int.Parse(Console.ReadLine());
                
                //ja adiciona o valor para a media
                total+= valores[i];
            }



            Console.WriteLine("\n=========== Resultado ===========");

            Console.WriteLine("\nO valor medio dos valores entrados é de {0} ", total / 10);

            Console.WriteLine("\n\nPrecione qualquer tecla para sair...");
            Console.ReadKey();
        }
    }
}
