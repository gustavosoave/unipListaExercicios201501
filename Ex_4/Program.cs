using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/*
 * Escreva um algoritmo para ler o número total de eleitores de um município,
 * o número de votos brancos, nulos e válidos. Calcular e escrever o
 * percentual que cada um representa em relação ao total de eleitores. 
 */

// eleitores = 100
// votos = x

// x * eleitores = 100 * votos
// x = 100*votos / eleitores


namespace Ex_4
{
    class Program
    {
        static void Main(string[] args)
        {
            int eleitores, brancos, nulos, validos;

            Console.WriteLine("Exercicio 4");
            Console.Write("Entre com o numero total de votos brancos : ");
            brancos = int.Parse(Console.ReadLine());
            Console.Write("Entre com o numero total de votos validos : ");
            validos = int.Parse(Console.ReadLine());
            Console.Write("Entre com o numero total de votos nulos   : ");
            nulos = int.Parse(Console.ReadLine());

            eleitores = brancos + nulos + validos;

            Console.WriteLine("\n=========== Resultado ===========");
            Console.WriteLine("\nNumero total de votos : {0}", eleitores);
            Console.WriteLine("Percentual de votos validos : {0}%", ((100 * validos ) / eleitores ) );
            Console.WriteLine("Percentual de votos brancos : {0}%", ((100 * brancos) / eleitores));
            Console.WriteLine("Percentual de votos nulos   : {0}%", ((100 * nulos ) / eleitores));

            Console.WriteLine("\n\nPrecione qualquer tecla para sair...");
            Console.ReadKey();

        }
    }
}
