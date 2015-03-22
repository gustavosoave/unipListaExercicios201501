using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ex_022
{
    class Program
    {
        static void Main(string[] args)
        {
            int valor;

            do
            {
                Console.WriteLine("Exercicio 22");
                Console.Write("Entre com um numero para a tabuada : ");
                valor = int.Parse(Console.ReadLine());

                if (valor < 1 && valor > 10)
                {
                    Console.WriteLine("É necessário entrar um número entre 1 e 10");
                    Console.ReadKey();
                }
            } while (valor < 1 && valor > 10);


            Console.WriteLine("\n=========== Resultado ===========");
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine("{0} x {1} = {2}", valor, i, valor * i);
            }

            Console.WriteLine("\n\nPrecione qualquer tecla para sair...");
            Console.ReadKey();
        }
    }
}
