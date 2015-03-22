using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/*
 * Ler um valor e escrever a mensagem É MAIOR QUE 10! se o valor lido for
 * maior que 10, caso contrário escrever NÃO É MAIOR QUE 10!
 */

namespace Ex_8
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
            Console.Write("\nO valor recebido ");

            if (valor > 10)
            {
                Console.Write("É MAIOR QUE 10!");
            }
            else {
                Console.Write("NÃO É MAIOR QUE 10!");

            }


            Console.WriteLine("\n\n=========== Resultado Usando ternario ===========");
            Console.WriteLine("\nO valor recebido {0}", (valor > 10 ? "É MAIOR QUE 10!" : "NÃO É MAIOR QUE 10!"));


            Console.WriteLine("\n\nPrecione qualquer tecla para sair...");
            Console.ReadKey();
        }
    }
}
