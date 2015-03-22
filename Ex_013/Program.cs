using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


/*
 * Ler dois valores (considere que não serão lidos valores iguais) e escrever o maior deles
 */

namespace Ex_013
{
    class Program
    {
        static void Main(string[] args)
        {
            double primeiro, segundo, maior;

            Console.WriteLine("Exercicio 13");

            Console.Write("\nEntre com o primeiro valor : ");
            primeiro = double.Parse(Console.ReadLine());
            Console.Write("Entre com o segundo valor : ");
            segundo = double.Parse(Console.ReadLine());

            if (primeiro > segundo)
            {
                maior = primeiro;
            }
            else {
                maior = segundo;
            }

            Console.WriteLine("\n=========== Resultado ===========");
            Console.WriteLine("\nO maior valor recebido foi {0}", maior);

            Console.WriteLine("\n\nPrecione qualquer tecla para sair...");
            Console.ReadKey();
        }
    }
}
