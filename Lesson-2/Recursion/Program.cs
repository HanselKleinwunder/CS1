using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Выполнил: Скворцов Александр
 * Разработать рекурсивный метод, который выводит на экран числа от a до b (a<b);
 * Разработать рекурсивный метод, который считает сумму чисел от a до b;
 */

namespace Recursion
{
    internal class Program
    {
        static void Rec(int a, int b)
        {
            if (a <= b)
            {
                Console.Write("{0}", a);
                Rec(a + 1, b);
            }
        }
        static int RecSum(int a, int b, int result)
        {
            if (a <= b)
            {
                result += a;
                return RecSum(a + 1, b, result);
            }
            else
            {
                return result;
            }
        }

        static void Main(string[] args)
        {
            int number1, number2;

            Console.Write("Введите первое число: ");
            number1 = int.Parse(Console.ReadLine());
            Console.Write("Введите второе число: ");
            number2 = int.Parse(Console.ReadLine());

            Rec(number1, number2);
            Console.Write("\nСумма чисел: " + RecSum(number1, number2, 0));

            Console.ReadLine();
        }
    }
}
