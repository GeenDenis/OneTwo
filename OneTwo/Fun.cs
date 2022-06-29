using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace OneTwo
{
    internal class Fun
    {
        public static void Timer()
        {
            Console.WriteLine("");
            Console.WriteLine("\t---------------------------------\t");
            for (int i = 0; i < 4; i++)
            {
                Console.Write("\tLoading");
                Thread.Sleep(500);
            }
            Console.WriteLine("");
            Console.WriteLine("\t---------------------------------\t");

        }
    }
}
