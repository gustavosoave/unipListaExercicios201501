using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/*
 * Escreva um algoritmo para ler 10 números. Todos os números lidos com
 * valor inferior a 40 devem ser somados. Escreva o valor final da soma
 * efetuada
 */

namespace Ex_029
{
    class Program
    {
        static void Main(string[] args)
        {
            double soma = 0;
            double atual;

            Console.WriteLine("Exercicio 29");

            for (int i = 0; i < 10; i++)
            {
                Console.Write("Entre com o {0}º valor : ", i + 1);
                atual = double.Parse(Console.ReadLine());
                if (atual < 40)
                    soma += atual;
            }

            Console.WriteLine("\n=========== Resultado ===========");

            Console.WriteLine("\nA soma dos valores entrados < 40 é de {0}", soma);

            Console.WriteLine("\n");

            Console.WriteLine("\n\nPrecione qualquer tecla para sair...");
            Console.ReadKey();

        }
    }
}
