using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/*
 * Fazer um programa para ler duas matrizes de M linhas e N colunas,
 *  contendo números inteiros. Depois, gerar uma terceira matriz onde cada
 *  elemento desta é a soma dos elementos correspondentes das matrizes
 *  originais. Imprimir na tela a matriz gerada
 */

namespace Ex_036
{
    class Program
    {
        static void Main(string[] args)
        {
            int linhas, colunas;
            int[,] matriz1, matriz2, matriz_soma;

            Console.WriteLine("Exercicio 36");

            Console.Write("Entre com o numero de linhas :");
            linhas = int.Parse(Console.ReadLine());

            Console.Write("Entre com o numero de colunas :");
            colunas = int.Parse(Console.ReadLine());

            matriz1 = new int[linhas, colunas];
            matriz2 = new int[linhas, colunas];
            matriz_soma = new int[linhas, colunas];

            Console.WriteLine(" =============== Matriz 1 ===============");

            for (int i = 0; i < linhas; i++) {
                for (int j = 0; j < colunas; j++) {
                    Console.Write("Entre com o valor {0} x {1} : ", i, j);
                    matriz1[i, j] = int.Parse(Console.ReadLine());
                }
            }


            Console.WriteLine(" =============== Matriz 2 ===============");  

            for (int i = 0; i < linhas; i++)
            {
                for (int j = 0; j < colunas; j++)
                {
                    Console.Write("Entre com o valor {0} x {1} : ", i, j);
                    matriz2[i, j] = int.Parse(Console.ReadLine());
                }
            }

            //Gerando a matriz 3

            for (int i = 0; i < linhas; i++)
            {
                for (int j = 0; j < colunas; j++)
                {
                    matriz_soma[i, j] = matriz1[i, j] + matriz2[i, j];
                }
            }


            Console.WriteLine("\n=========== Resultado ===========");

            Console.WriteLine(" =============== Matriz 3 ===============");
            for (int i = 0; i < linhas; i++)
            {
                for (int j = 0; j < colunas; j++)
                {
                    Console.Write(matriz_soma[i, j]);
                    if (j < colunas -1)
                        Console.Write(", ");
                }
                Console.Write("\n");
            }

            Console.WriteLine("\n\nPrecione qualquer tecla para sair...");
            Console.ReadKey();
        }
    }
}
