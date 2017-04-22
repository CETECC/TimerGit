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
            Console.Write("Quantos segundos deseja? ");
            string strTempo = Console.ReadLine();

            int tempo = int.Parse(strTempo);

            for (int i = 0; i < tempo; i++)
            {
                Console.WriteLine(i);
                Thread.Sleep(1000);
            }

            Console.WriteLine();
            Console.WriteLine("Encerrado após {0} segundos.", tempo);
        }
    }
}
