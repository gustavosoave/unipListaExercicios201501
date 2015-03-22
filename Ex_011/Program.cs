using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/*
 * Ler as notas da 1a. e 2a. avaliações de um aluno. Calcular a média
 * aritmética simples e escrever uma mensagem que diga se o aluno foi ou
 * não aprovado (considerar que nota igual ou maior que 6 o aluno é
 * aprovado). Escrever também a média calculada.
 */

namespace Ex_011
{
    class Program
    {
        static void Main(string[] args)
        {
            double np1, np2, nota_final;

            Console.WriteLine("Exercicio 11");

            Console.WriteLine("\nUtilize o valor no formato Americano");
            Console.WriteLine("Ex: 4.75");

            Console.Write("Entre com a nota da primeira prova :");
            np1 = double.Parse(Console.ReadLine());
            Console.Write("Entre com a nota da segunda prova  :");
            np2 = double.Parse(Console.ReadLine());

            nota_final = (np1 + np2) / 2;

            Console.WriteLine("\n=========== Resultado ===========");
            Console.WriteLine("\nO aluno foi : {0}", (nota_final >= 6 ? "Aprovado" : "Reprovado" ));
            Console.WriteLine("A nota final do aluno foi : {0}", nota_final);

            Console.WriteLine("\n\nPrecione qualquer tecla para sair...");
            Console.ReadKey();
        }
    }
}
