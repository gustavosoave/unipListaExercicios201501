using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/*
 * Faça um algoritmo que leia a idade de uma pessoa expressa em anos,
 * meses e dias e escreva a idade dessa pessoa expressa apenas em dias.
 * Considerar ano com 365 dias e mês com 30 dias
 * 
 */

namespace Ex_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int anos, meses, dias;

            Console.WriteLine("Exercicio 4");
            
            Console.Write("\nEntre com a idade em anos : ");
            anos = int.Parse(Console.ReadLine());

            Console.Write("\nEntre com a idade em meses : ");
            meses = int.Parse(Console.ReadLine());

            Console.Write("\nEntre com a idade em dias : ");
            dias = int.Parse(Console.ReadLine());

            Console.WriteLine("\n=========== Resultado ===========");
            Console.WriteLine("\nA sua idade em dias e : {0}", ((anos * 365) + (meses * 30) + dias));

            Console.WriteLine("\n\nPrecione qualquer tecla para sair...");
            Console.ReadKey();
        }
    }
}
