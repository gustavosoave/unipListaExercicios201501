using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/*
 * Ler a hora de início e a hora de fim de um jogo de Xadrez (considere
 * apenas horas inteiras, sem os minutos) e calcule a duração do jogo em
 * horas, sabendo-se que o tempo máximo de duração do jogo é de 24 horas
 * e que o jogo pode iniciar em um dia e terminar no dia seguinte
 * 
 */

namespace Ex_015
{
    class Program
    {
        static void Main(string[] args)
        {
            int hora_inicial, hora_final, tempo_jogo;

            Console.WriteLine("Exercicio 15");
            Console.Write("\nEntre com a hora inicial do jogo : ");
            hora_inicial = int.Parse(Console.ReadLine());
            Console.Write("\nEntre com a hora final do jogo : ");
            hora_final = int.Parse(Console.ReadLine());

            tempo_jogo = hora_final - hora_inicial;

            if (tempo_jogo <= 0) {
                tempo_jogo = tempo_jogo + 24;
            }

            Console.WriteLine("\n=========== Resultado ===========");
            Console.WriteLine("\nO jogo durou {0} hora(s)", tempo_jogo);

            Console.WriteLine("\n\nPrecione qualquer tecla para sair...");
            Console.ReadKey();
        }
    }
}
