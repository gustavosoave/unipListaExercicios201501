using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/*
 * Ler 10 valores e escrever quantos desses valores lidos são NEGATIVOS.
 */

namespace Ex_024
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] valores = new double[10];
            int negativos = 0;


            Console.WriteLine("Exercicio 24");
            
            for (int i = 0; i < 10; i++) {
                Console.Write("Entre com o {0}º numero : ", i + 1);
                valores[i] = double.Parse(Console.ReadLine());
            }

            
            for (int i = 0; i < 10; i++) {
                if(valores[i] < 0){
                    negativos++;
                }
            }


            Console.Clear();

            Console.WriteLine("\n=========== Resultado ===========");

            Console.WriteLine("Os numeros negativos são: {0}", negativos);
    
            Console.WriteLine("\n\nPrecione qualquer tecla para sair...");
            Console.ReadKey();
        }
    }
}
