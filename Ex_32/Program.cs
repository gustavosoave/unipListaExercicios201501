using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/*
 * Escreva um algoritmo que permita a leitura das notas de uma turma de 20
 * alunos. Calcular a média da turma e contar quantos alunos obtiveram nota
 * acima desta média calculada. Escrever a média da turma e o resultado da
 * contagem
 */

namespace Ex_32
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] notas = new double[20];
            double media = 0;
            int notas_azuis = 0;

            Console.WriteLine("Exercicio 32");

            for (int i = 0; i < 20; i++) {
                Console.Write("Entre com a nota do {0}º aluno : ", i + 1);
                notas[i] = double.Parse(Console.ReadLine());
                media += notas[i];
            }

            media = media / 20;

            for (int i = 0; i < 20; i++) {
                if (notas[i] > media)
                    notas_azuis++;
            }

            Console.WriteLine("\n=========== Resultado ===========");

            Console.WriteLine("\nA média da nota dos alunos é de {0}", media);
            Console.WriteLine("{0} alunos tiveram notas acima da média.", notas_azuis);

            Console.WriteLine("\n\nPrecione qualquer tecla para sair...");
            Console.ReadKey();
        }
    }
}
