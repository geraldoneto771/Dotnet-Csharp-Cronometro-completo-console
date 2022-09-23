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
            Console.WriteLine("S = Segundo => 10s =  10 segundos");
            Console.WriteLine("M = Minuto => 1m = 1 minuto");
            Console.WriteLine("0 = Sair");
            Console.WriteLine("---------------------------");
            Console.WriteLine("Quanto tempo deseja contar?");
            //Console.WriteLine("---------------------------");

            //Entrada de dados e convertendo para string em minusculo
            string data = Console.ReadLine().ToLower();
            Console.WriteLine("D = Contagem Decrescente");
            Console.WriteLine("C = Contagem Crescente");
            char typeCount = char.Parse(Console.ReadLine().ToLower());
            char type = char.Parse(data.Substring(data.Length - 1, 1));
            int time = int.Parse(data.Substring(0, data.Length - 1));
            int multiplier = 1;

            if (type == 'm')
            {
                multiplier = 60;
                time *= multiplier;
            }
            if (type == 's')
            {
                multiplier = 1;
                time *= multiplier;
            }
            if (time == 0)
            {
                System.Environment.Exit(0);
            }
            PreStart(time, typeCount);


        }


        static void PreStart(int time, char typeCount)
        {
            Console.Clear();
            Console.WriteLine("Ready...");
            Thread.Sleep(1000);
            Console.WriteLine("Set...");
            Thread.Sleep(1000);
            Console.WriteLine("Go...");
            Thread.Sleep(2000);
            Start(time, typeCount);
        }

        static void Start(int time, char typeCount)
        {
            // tempo atual
            int currentTime;
            if (typeCount == 'c')
            {
                currentTime = 0;
                while (currentTime != time)
                {
                    Console.Clear();
                    currentTime++;
                    Console.WriteLine(currentTime);
                    //Thread - execução atual do programa //Sleep - dormir //Thread.Sleep() faça a execução do programa dormir por tantos milisegundos
                    Thread.Sleep(1000);

                }
            }
            else if (typeCount == 'd')
            {
                currentTime = time + 1;
                while (currentTime > 0)
                {
                    Console.Clear();
                    currentTime--;
                    Console.WriteLine(currentTime);
                    //Thread - execução atual do programa //Sleep - dormir //Thread.Sleep() faça a execução do programa dormir por tantos milisegundos
                    Thread.Sleep(1000);

                }
            }


            Console.Clear();
            Console.WriteLine("Stopwatch finalizado...");
            Thread.Sleep(2500);
            Menu();
        }

    }
}

//Desafios para este projeto
/*
    - Adicionar no menu a opção de cronometro crescente ou decrescente; OK
    - Adicionar validações das entradas
*/