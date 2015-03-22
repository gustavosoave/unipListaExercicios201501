using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/*
 * Ler o número de alunos existentes em uma turma e, após isto, ler as notas
 * destes alunos, calcular e escrever a média aritmética dessas notas lidas.
 */

namespace Ex_027
{
    class Program
    {
        static void Main(string[] args)
        {
            int alunos;
            int notas_total;
            int[] notas;

            notas_total = 0;

            Console.WriteLine("Exercicio 27");

            Console.Write("Entre com o numero de alunos : ");
            alunos = int.Parse(Console.ReadLine());

            notas = new int[alunos];

            for (int i = 0; i < alunos; i++) {
                Console.Write("Entre com a nota do {0}º aluno : ");
                notas[i] = int.Parse(Console.ReadLine());
                notas_total += notas[i];
            }

            Console.WriteLine("\n=========== Resultado ===========");

            Console.WriteLine("\nA media aritimetica das notas é de {0}", notas_total / alunos);

            Console.WriteLine("\n\nPrecione qualquer tecla para sair...");
            Console.ReadKey();
        }
    }
}
