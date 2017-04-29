using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TimerGit
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("De qual numero deseja comecar? ");
            string strInicio = Console.ReadLine();

            Console.Write("Em qual numero deseja terminar? ");
            string strTempo = Console.ReadLine();

            int inicio = int.Parse(strInicio);
            int tempo = int.Parse(strTempo);

            for (int i = inicio; i < tempo; i++)
            {
                if (i % 2 == 0)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                }
                Console.WriteLine(i);
                Thread.Sleep(1000);
            }

            Console.ResetColor();

            Console.WriteLine();
            Console.WriteLine("Encerrado no contador {0}.", tempo);
        }
    }
}
