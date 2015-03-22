using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/*
 * Escreva um algoritmo para ler o salário mensal atual de um funcionário e o
 * percentual de reajuste. Calcular e escrever o valor do novo salário.
 */ 


namespace Ex_5
{
    class Program
    {
        static void Main(string[] args)
        {
            double salario, reajuste;

            Console.WriteLine("Exercicio 5");
            Console.WriteLine("\nUtilize o formato Americano de numeros");
            Console.WriteLine("Ex: 800.00");

            Console.Write("\nEntre com o valor atual do seu salario : ");
            salario = double.Parse(Console.ReadLine());
            Console.Write("Entre com o valor percentual do reajuste : ");
            reajuste = double.Parse(Console.ReadLine());

            Console.WriteLine("\n=========== Resultado ===========");
            Console.WriteLine("\nO seu novo salario será de : {0}", (salario * (1 + (reajuste / 100))) );
            
            Console.WriteLine("\n\nPrecione qualquer tecla para sair...");
            Console.ReadKey();

        }

    }
}
