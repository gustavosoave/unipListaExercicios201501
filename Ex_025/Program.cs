using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/*
 * 5.Ler 10 valores e escrever quantos desses valores lidos estão no intervalo
 * [10,20] (incluindo os valores 10 e 20 no intervalo) e quantos deles estão
 * fora deste intervalo.
 */

namespace Ex_025
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] valores = new int[10];
            int j = 0;
            int k = 0;
            
            Console.WriteLine("Exercicio 25");

            for (int i = 0; i < 10; i++) {
                Console.Write("Entre com o {0}º valor : ", i + 1);
                valores[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < 10; i++) {
                if (valores[i] >= 10 && valores[i] <= 20)
                {
                    j++;
                }
                else {
                    k++;
                }

            }

            Console.WriteLine("\n=========== Resultado ===========");

            Console.WriteLine("Os numeros dentro de intervalo de 10 à 20 : {0}", j);

           

            Console.WriteLine("Os numeros fora de intervalo de 10 à 20 : {0}", k);

            Console.WriteLine("\n\nPrecione qualquer tecla para sair...");
            Console.ReadKey();

        }
    }
}
