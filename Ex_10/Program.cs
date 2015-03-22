using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/*
 * As maçãs custam R$ 1,30 cada se forem compradas menos de uma dúzia,
 * e R$ 1,00 se forem compradas pelo menos 12. Escreva um programa que
 * leia o número de maçãs compradas, calcule e escreva o custo total da
 * compra.
 */


namespace Ex_10
{
    class Program
    {
        static void Main(string[] args)
        {

            int macas;
            double valor;

            Console.WriteLine("Exercicio 10");

            Console.Write("Entre com o numero de maças compradas : ");
            macas = int.Parse(Console.ReadLine());

            valor = ((macas / 12) * 12)  + ((macas % 12) * 1.3);

            Console.WriteLine("\n=========== Resultado ===========");
            Console.Write("\nO valor pago foi de  : {0}", String.Format("R$ {0:0.00}", valor));

            Console.WriteLine("\n\nPrecione qualquer tecla para sair...");
            Console.ReadKey();
        }
    }
}
