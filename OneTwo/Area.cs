using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OneTwo
{
    internal class Area
    {
        public static void Print(int[] AreaPrint)
        {
            Console.WriteLine("");
            Console.WriteLine("\t---------------------------------\t");
            for (int i = 0; i < AreaPrint.Length; i++)
            {
                if (i % 3 == 0)
                {
                    Console.WriteLine("");
                    Console.WriteLine("");
                    Console.WriteLine("");
                    Console.Write("\t" + AreaPrint[i] + "\t");
                }
                else Console.Write("\t" + AreaPrint[i] + "\t");
            }
        }
        public static void ClearArea(int[] AreaPrint)
        {
            Console.WriteLine("");
            Console.WriteLine("\t---------------------------------\t");
            for (int i = 0; i < AreaPrint.Length; i++)
            {
                if (i % 3 == 0)
                {
                    Console.WriteLine("");
                    Console.WriteLine("");
                    Console.WriteLine("");
                    AreaPrint[i] = 0;
                    Console.Write("\t" + AreaPrint[i] + "\t");
                }
                else
                {
                    AreaPrint[i] = 0;
                    Console.Write("\t" + AreaPrint[i] + "\t");
                }
            }
        }
    }
}



