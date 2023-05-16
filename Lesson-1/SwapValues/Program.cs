using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Выполнил: Скворцов Александр
 * Написать программу обмена значениями двух переменных.
 * а) с использованием третьей переменной;
 * б) без использования третьей переменной.
 */

namespace SwapValues
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a, b, c;

            Console.Write("Введите значение для переменной a: ");
            a = int.Parse(Console.ReadLine());
            Console.Write("Введите значение для переменной b: ");
            b = int.Parse(Console.ReadLine());

            //c = a;
            //a = b;
            //b = c;

            a = a + b;
            b = a - b;
            a = a - b;

            Console.WriteLine("Значение a: {0}", a);
            Console.WriteLine("Значение b: {0}", b);

            Console.ReadKey();
        }
    }
}
