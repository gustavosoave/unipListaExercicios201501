using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/*
 * Faça um algoritmo para ler um valor N qualquer (que será o tamanho dos
 * vetores). Após, ler dois vetores A e B (de tamanho N cada um) e depois
 * armazenar em um terceiro vetor Soma a soma dos elementos do vetor A
 * com os do vetor B (respeitando as mesmas posições) e escrever o vetor
 * Soma
 */

namespace Ex_033
{
    class Program
    {
        static void Main(string[] args)
        {
            int tamanho;
            int[] vetor1, vetor2, soma;

            Console.WriteLine("Exercicio 33");

            Console.Write("Entre com o tamanho dos vetores : ");
            tamanho = int.Parse(Console.ReadLine());

            vetor1 = new int[tamanho];
            vetor2 = new int[tamanho];
            soma = new int[tamanho];

            Console.WriteLine("========= Vetor 1 =========");
            for (int i = 0; i < tamanho; i++) {
                Console.Write("Entre com o {0} valor : ", i+1);
                vetor1[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("========= Vetor 2 =========");
            for (int i = 0; i < tamanho; i++)
            {
                Console.Write("Entre com o {0} valor : ", i + 1);
                vetor2[i] = int.Parse(Console.ReadLine());
            }

            //somando
            for (int i = 0; i < tamanho; i++) {
                soma[i] = vetor1[i] + vetor2[i];
            }
            
            Console.WriteLine("\n=========== Resultado ===========");

            Console.WriteLine("\nAbaixo o valor soma:");

            for (int i = 0; i < tamanho; i++) {
                Console.WriteLine("SOMA[{0}] = {1}", i, soma[i]);
            }

            Console.WriteLine("\n\nPrecione qualquer tecla para sair...");
            Console.ReadKey();
        }
    }
}
