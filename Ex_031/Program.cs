using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/*
 * Escreva um algoritmo que permita a leitura dos nomes de 10 pessoas e
 * armazene os nomes lidos em um vetor. Após isto, o algoritmo deve permitir
 * a leitura de mais 1 nome qualquer de pessoa e depois escrever a
 * mensagem ACHEI, se o nome estiver entre os 10 nomes lidos
 * anteriormente (guardados no vetor), ou NÃO ACHEI caso contrário
 */

namespace Ex_031
{
    class Program
    {
        static void Main(string[] args)
        {
            String[] nomes = new String[10];
            String nome;

            Console.WriteLine("Exercicio 31");

            for (int i = 0; i < 10; i++) {
                Console.Write("Entre com o {0}º nome : ", i+1);
                nomes[i] = Console.ReadLine();
            }

            Console.Write("Entre com o nome a ser buscado : ");
            nome = Console.ReadLine();

            Console.WriteLine("\n=========== Resultado ===========");

            Console.WriteLine("O resultado é : {0}", buscar(nomes, nome) ? "ACHEI!" : "NÃO ACHEI!");

            Console.WriteLine("\n\nPrecione qualquer tecla para sair...");
            Console.ReadKey();


        }

        private static bool buscar(String[] nomes, String busca){
            for (int i = 0; i < 10; i++)
            {
                if (nomes[i].Equals(busca))
                    return true;
            }

            return false;
        }
    }
}
