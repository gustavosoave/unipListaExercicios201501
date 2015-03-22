using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/*
 * Uma revendedora de carros usados paga a seus funcionários vendedores
 * um salário fixo por mês, mais uma comissão também fixa para cada carro
 * vendido e mais 5% do valor das vendas por ele efetuadas. Escrever um
 * algoritmo que leia o número de carros por ele vendidos, o valor total de
 * suas vendas, o salário fixo e o valor que ele recebe por carro vendido.
 * Calcule e escreva o salário final do vendedor.
 * 
 */

namespace Ex_7
{
    class Program
    {
        static void Main(string[] args)
        {
            double valor_vendas, valor_salario;

            Console.WriteLine("Exercicio 6");
            Console.WriteLine("\nUtilize o valor no formato Americano");
            Console.WriteLine("Ex: 800.00");

            Console.Write("\nEntre com o valor do salario do vendedor : ");
            valor_salario = double.Parse(Console.ReadLine());
            Console.Write("Entre com o valor total de vendas deste vendedor neste mes : ");
            valor_vendas = double.Parse(Console.ReadLine());

            Console.WriteLine("\n=========== Resultado ===========");
            Console.WriteLine("\nO valor que este vendedor receberá este mes é de : {0}", (valor_salario + (valor_vendas * 0.05 )));

            Console.WriteLine("\n\nPrecione qualquer tecla para sair...");
            Console.ReadKey();

        }
    }
}
