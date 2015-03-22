using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/*
 * Escreva um algoritmo para ler as dimensões de um retângulo (base e
 * altura), calcular e escrever a área do retângulo. 
 */

namespace Ex_2
{
    class Program
    {
        static void Main(string[] args)
        {
            double altura, comprimento;
            
            Console.WriteLine("Exercicio 2");
            Console.WriteLine("Entre com os dados para o calculo do retangulo:");
            Console.Write("Altura  : ");
            altura = double.Parse(Console.ReadLine());
            Console.Write("Comprimento : ");
            comprimento = double.Parse(Console.ReadLine());

            Console.WriteLine("=========== Resultado ===========");
            Console.WriteLine("\nArea do retangulo = {0}²", altura*comprimento);
            Console.WriteLine("\n\nPrecione qualquer tecla para sair...");
            Console.ReadKey();

        }
    }
}
