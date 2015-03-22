using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/*
 * Faça um algoritmo para ler e armazenar em um vetor a temperatura média
 * de todos os dias do ano. Calcular e escrever:
 *   a. Menor temperatura do ano
 *   b. Maior temperatura do ano
 *   c. Temperatura média anual
 *   d. O número de dias no ano em que a temperatura foi inferior a média
 * anual
 * 
 */

namespace Ex_034
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] dias = new double[365];
            double menor = 1000000, maior = -100000, media = 0;
            int diaAno = 0, diasAbaixoMedia = 0;

            Console.WriteLine("Exercicio 34");
            for(int i = 0 ; i < 12 ; i ++){
                for(int j = 0; j < dias_mes(i+1); j++){
                    Console.Write("Entre com a temperatura do dia {0}/{1} : ", j+1, String.Format("{0:00}", i+1));
                    dias[diaAno] = double.Parse(Console.ReadLine());

                    media += dias[diaAno];

                    diaAno++;
                }
            }

            media = media / (diaAno-1);

            for(int i = 0; i < diaAno ; i++){
            
                if(dias[i] > maior){
                    maior = dias[i];
                }

                if(dias[i] < menor){
                    menor = dias[i];
                }
                    
                if(dias[i] < media){
                    diasAbaixoMedia++;
                }
            }

            Console.WriteLine("\n=========== Resultado ===========");

            Console.WriteLine("A temperatura media durante o ano foi de : {0}", media);
            Console.WriteLine("A maior temperatura foi : {0}", maior);
            Console.WriteLine("A menor temperatura foi : {0}", menor);
            Console.WriteLine("Tiveram {0} dias abaixo da média", diasAbaixoMedia);

            Console.WriteLine("\n\nPrecione qualquer tecla para sair...");
            Console.ReadKey();
        }

        private static int dias_mes(int mes) {

            switch (mes) { 
                case 1:
                    return 31;
                    break;
                case 2:
                    return 28;
                    break;
                case 3:
                    return 31;
                    break;
                case 4:
                    return 30;
                    break;
                case 5:
                    return 31;
                    break;
                case 6:
                    return 30;
                    break;
                case 7:
                    return 31;
                    break;
                case 8:
                    return 31;
                    break;
                case 9:
                    return 30;
                    break;
                case 10:
                    return 31;
                    break;
                case 11:
                    return 30;
                    break;
                default:
                    return 31;
                    break;
            }
                
           }

        }
    }

