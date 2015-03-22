using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/*
 * 
 * Escreva um algoritmo para ler um valor (do teclado) e escrever (na tela) o
 * seu antecessor.
 * 
 */

namespace Ex_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int atual;

            Console.WriteLine("Exercicio 1");
            Console.Write("\nEscreva um numero para descobrir o seu anterior: ");
            atual = int.Parse(Console.ReadLine());

            Console.Clear();
            Console.WriteLine("=========== Resultado ===========");
            Console.WriteLine("Atual    : {0}", atual);
            Console.WriteLine("Anterior : {0}", atual - 1);
            Console.WriteLine("\n\nPrecisone qualquer tecla para sair... ");
            Console.ReadKey();

        }
    }
}
