using System;
using System.Threading;

namespace Stopwatch // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Menu();
        }

        static void Menu()
        {
            Console.Clear();
            Console.WriteLine("---------CRONÔMETRO--------");
            Console.WriteLine("---------------------------");
            Console.WriteLine("S = Segundo");
            Console.WriteLine("M = Minuto");
            Console.WriteLine("0 = Sair");
            Console.WriteLine("---------------------------");
            Console.WriteLine("Quanto tempo deseja contar?");
            //Console.WriteLine("---------------------------");
        }

        static void Start(int time)
        {
            // tempo atual
            int currentTime = 0;

            while (currentTime != time)
            {
                Console.Clear();
                currentTime++;
                Console.WriteLine(currentTime);
                //Thread - execução atual do programa //Sleep - dormir //Thread.Sleep() faça a execução do programa dormir por tantos milisegundos
                Thread.Sleep(1000);

            }

            Console.Clear();
            Console.WriteLine("Stopwatch finalizado...");
            Thread.Sleep(2500);
        }

    }
}