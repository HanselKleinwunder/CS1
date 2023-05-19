using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Выполнил: Скворцов Александр
 * Написать метод, возвращающий минимальное из трех чисел.
*/

namespace MinOfThreeNumbers
{
    internal class Program
    {
        static int MinOfThree(int a, int b, int c)
        {
            if (a > b && b < c)
            {
                return b;
            }
            else if(a > c && c < b)
            {
                return c;
            }
            else
            {
                return a;
            }
        }

        static void Main(string[] args)
        {
            int a, b, c;

            Console.Write("Пожалуйста, введите первое число: ");
            a = int.Parse(Console.ReadLine());
            Console.Write("Пожалуйста, введите второе число: ");
            b = int.Parse(Console.ReadLine());
            Console.Write("Пожалуйста, введите третье число: ");
            c = int.Parse(Console.ReadLine());

            Console.Write("Минимальное из трёх введённых чисел: " + MinOfThree(a, b, c));

            Console.ReadLine();
        }
    }
}
