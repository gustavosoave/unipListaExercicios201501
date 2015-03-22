using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/*
 * O custo de um carro novo ao consumidor é a soma do custo de fábrica com
 * a porcentagem do distribuidor e dos impostos (aplicados ao custo de
 * fábrica). Supondo que o percentual do distribuidor seja de 28% e os
 * impostos de 45%, escrever um algoritmo para ler o custo de fábrica de um
 * carro, calcular e escrever o custo final ao consumidor.
 * 
 */

namespace Ex_6
{
    class Program
    {
        static void Main(string[] args)
        {
            double valor_inicial ;
            double distribuidor = 28; 
            double impostos = 45;

            Console.WriteLine("Exercicio 6");
            Console.WriteLine("\nUtilize o valor no formato Americano");
            Console.WriteLine("Ex: 800.00");

            Console.Write("Entre com o valor do carro fornecido pelo fabricante : ");
            valor_inicial = double.Parse(Console.ReadLine());

            Console.WriteLine("\n=========== Resultado ===========");
            Console.WriteLine("\nO valor final do carro sera : {0}", (valor_inicial * (1 + ((distribuidor/100) + (impostos/100)))) );

            Console.WriteLine("\n\nPrecione qualquer tecla para sair...");
            Console.ReadKey();

        }
    }
}
