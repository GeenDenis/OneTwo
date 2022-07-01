using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OneTwo
{
    internal class Corected
    {
           public int[] AreaSystem = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
           public static void AreaCorrected(int[] Area, int gameNumber)
        {
            Console.WriteLine("Введите номер клетки");
            int Coordinate = int.Parse(Console.ReadLine());
            Coordinate = Coordinate - 1;
            if (gameNumber % 2 ==0) { Area[Coordinate] = 1; }
            else { Area[Coordinate] = 2; }
        }

    }
}
