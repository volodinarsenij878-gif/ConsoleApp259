using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program100
{
    internal class Program
    {
        static void Main()
        {
            Console.Write("Введите число: ");
            if (double.TryParse(Console.ReadLine(), out double value))
            {
                bool inRange1 = value >= 0 && value <= 10;
                bool inRange2 = value >= 20 && value <= 30;
                bool inRange3 = value >= 50 && value <= 100;

                if (inRange1 || inRange2 || inRange3)
                {
                    Console.Write("Число попадает хотя бы в один из указанных интервалов: ");
                    if (inRange1) Console.Write("[0;10] ");
                    if (inRange2) Console.Write("[20;30] ");
                    if (inRange3) Console.Write("[50;100] ");
                    Console.WriteLine();
                }
                else
                {
                    Console.WriteLine("Число не попадает ни в один из указанных интервалов.");
                }
            }
            else
            {
                Console.WriteLine("Ошибка: введите корректное число.");
            }
        }
    }
}