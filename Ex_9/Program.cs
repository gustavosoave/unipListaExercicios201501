using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/*
 * Ler um valor e escrever se é positivo ou negativo (considere o valor zero como positivo)
 */

namespace Ex_9
{
    class Program
    {
        static void Main(string[] args)
        {

            double valor;

            Console.WriteLine("Exercicio 6");
            Console.Write("\nEntre com o valor para analise : ");
            valor = double.Parse(Console.ReadLine());

            Console.WriteLine("\n=========== Resultado ===========");
            Console.Write("\nO valor recebido {0}", (valor >= 0 ? "Positivo" : "Negativo"));

            Console.WriteLine("\n\nPrecione qualquer tecla para sair...");
            Console.ReadKey();
        }
    }
}
