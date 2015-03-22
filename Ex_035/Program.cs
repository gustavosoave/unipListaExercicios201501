using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/*
 * .Fazer um programa para ler uma matriz quadrada de ordem N, contendo
 * números reais. Em seguida, fazer as seguintes ações:
 *   a. Calcular e imprimir a soma de todos os elementos positivos da
 *   matriz.
 *   b. Fazer a leitura do índice de uma linha da matriz e, daí, imprimir todos
 *   os elementos desta linha.
 *   c. Fazer a leitura do índice de uma coluna da matriz e, daí, imprimir
 *   todos os elementos desta coluna.
 *   d. Imprimir os elementos da diagonal principal da matriz.
 *   e. Em seguida imprimir a matriz alterada.
 * 
 */

namespace Ex_035
{
    class Program
    {
        static void Main(string[] args)
        {
            double[,] matriz;
            double soma = 0;
            int n, linha, coluna;

            Console.WriteLine("Exercicio 35");

            Console.Write("Entre com o tamanho para a matriz quadrada : ");
            n = int.Parse(Console.ReadLine());

            matriz = new double[n,n];

            for(int i = 0; i < n ; i++){
                for(int j = 0; j < n; j++){
                    Console.Write("Entre com o valor {0}x{1} : ", i, j);
                    matriz[i, j] = double.Parse(Console.ReadLine());
                }
            }

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    soma += matriz[i, j];
                }
            }
                
            Console.WriteLine("\n=========== Resultado ===========");

            Console.Write("A soma de todos os numeros positivo é : {0}", soma);

            Console.Write("\nEntre com o numero da linha a ser impressa :");
            linha = int.Parse(Console.ReadLine());

            Console.WriteLine("Abaixo a linha {0} :");

            for (int i = 0; i < n; i++) {
                Console.Write(matriz[linha, i]);
                if (i < n)
                    Console.Write(", ");
            }

            Console.Write("\nEntre com o numero da coluna a ser impressa :");
            coluna = int.Parse(Console.ReadLine());

            Console.WriteLine("Abaixo a coluna {0} :");

            for (int i = 0; i < n; i++) {
                Console.Write(matriz[i, coluna]);
                if (i < n)
                    Console.Write(", ");
            }

            Console.WriteLine("\nAbaixo a diagonal principal da matriz :");

            for (int i = 0; i < n; i++) {
                Console.Write(matriz[i, i]);
                if (i < n)
                    Console.Write(", ");
            }

            Console.WriteLine("\n\nPrecione qualquer tecla para sair...");
            Console.ReadKey();
        }
    }
}
