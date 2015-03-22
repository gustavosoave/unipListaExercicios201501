using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/*
 * Ler o ano atual e o ano de nascimento de uma pessoa. Escrever uma
 * mensagem que diga se ela poderá ou não votar este ano (não é necessário
 * considerar o mês em que a pessoa nasceu)
 */

namespace Ex_012
{
    class Program
    {
        static void Main(string[] args)
        {
            int ano_atual;
            int ano_nascimento;

            Console.WriteLine("Exercicio 12");

            Console.Write("\n\nEntre com o ano de nascimento : ");
            ano_nascimento = int.Parse(Console.ReadLine());

            ano_atual = DateTime.Now.Year;

            Console.WriteLine("\n=========== Resultado ===========");
            Console.WriteLine("\nEsta pessoa {0}", (ano_atual - ano_nascimento) >= 16 ? "PODE VOTAR!":"NÃO PODE VOTAR!");

            Console.WriteLine("\n\nPrecione qualquer tecla para sair...");
            Console.ReadKey();
        }
    }
}
