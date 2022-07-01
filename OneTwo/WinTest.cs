using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OneTwo
{
    internal class WinTest //Я ничего не придумал((( Прилошлось нарушить правила полиморфизма и сделать хардкод(
    {
        public static void WinDiaganal(int[] Area)
        {
                if (Area[0]==1 && Area[1]==1 && Area[2]==1)
                {
                Console.WriteLine("WIN = 1");
                }
                else if(Area[3] == 1 && Area[4] == 1 && Area[5] == 1)
                {
                Console.WriteLine("WIN = 1");
                }
                else if (Area[6] == 1 && Area[7] == 1 && Area[8] == 1)
                {
                Console.WriteLine("WIN = 1");
                }
            else if (Area[0] == 2 && Area[1] == 2 && Area[2] == 2)
            {
                Console.WriteLine("WIN = 2");
            }
            else if (Area[3] == 2 && Area[4] == 2 && Area[5] == 2)
            {
                Console.WriteLine("WIN = 2");
            }
            else if (Area[6] == 2 && Area[7] == 2 && Area[8] == 2)
            {
                Console.WriteLine("WIN = 2");
            }
        }
        public static void WinVertical(int[] Area)
        {
            if (Area[0] == 1 && Area[3] == 1 && Area[7] == 1)
            {
                Console.WriteLine("WIN = 1");
            }
            else if (Area[1] == 1 && Area[4] == 1 && Area[7] == 1)
            {
                Console.WriteLine("WIN = 1");
            }
            else if (Area[2] == 1 && Area[5] == 1 && Area[8] == 1)
            {
                Console.WriteLine("WIN = 1");
            }
            if (Area[0] == 2 && Area[3] == 2 && Area[7] == 2)
            {
                Console.WriteLine("WIN = 2");
            }
            else if (Area[1] == 2 && Area[4] == 2 && Area[7] == 2)
            {
                Console.WriteLine("WIN = 2");
            }
            else if (Area[2] == 2 && Area[5] == 2 && Area[8] == 2)
            {
                Console.WriteLine("WIN = 2");
            }
        }
        public static void WinCenter(int[] Area)
        {
            if (Area[0] == 1 && Area[4] == 1 && Area[8] == 1)
            {
                Console.WriteLine("WIN = 1");
            }
            if (Area[6] == 1 && Area[4] == 1 && Area[2] == 1)
            {
                Console.WriteLine("WIN = 1");
            }
            if (Area[0] == 2 && Area[4] == 2 && Area[8] == 2)
            {
                Console.WriteLine("WIN = 2");
            }
            if (Area[6] == 2 && Area[4] == 2 && Area[2] == 2)
            {
                Console.WriteLine("WIN = 2");
            }

        }
    }
}
