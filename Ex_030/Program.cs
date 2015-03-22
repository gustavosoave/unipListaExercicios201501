using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/*
 * Ler 2 valores, calcular e escrever a soma dos inteiros existentes entre os 2
 * valores lidos (incluindo os valores lidos na soma). Considere que o segundo
 * valor lido será sempre maior que o primeiro valor lido.
 */

namespace Ex_030
{
    class Program
    {
        static void Main(string[] args)
        {
            int inicio, fim;
            int soma = 0;

            Console.WriteLine("Exercicio 30");

            Console.Write("Entre com o valor de inicio : ");
            inicio = int.Parse(Console.ReadLine());

            Console.Write("Entre com o valor final : ");
            fim = int.Parse(Console.ReadLine());

            for (int i = inicio; i <= fim; i++) {
                soma += i;
            }

            Console.WriteLine("\n=========== Resultado ===========");

            Console.WriteLine("\nA soma do intervalo é de {0}", soma);

            Console.WriteLine("\n\nPrecione qualquer tecla para sair...");
            Console.ReadKey();

        }
    }
}
