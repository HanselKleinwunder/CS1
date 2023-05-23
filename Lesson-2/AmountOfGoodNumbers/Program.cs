using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Выполнил: Скворцов Александр
 * Написать программу подсчета количества «Хороших» чисел в диапазоне от 1 до 1 000 000 000. 
 * Хорошим называется число, которое делится на сумму своих цифр. 
 * Реализовать подсчет времени выполнения программы, используя структуру DateTime.
 */

namespace AmountOfGoodNumbers
{
    internal class Program
    {
        static bool goodNumbers(int number)
        {
            int sum = 0;
            string n = number.ToString();

            for (int i = 1; i < n.Length; i++)
            {
                sum += n[i] - '0';
            }

            if (number % sum == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        static void Main(string[] args)
        {
            int number = 1000000000;

            Console.WriteLine("Количество хороших чисел: {0}", goodNumbers(number));
        }
    }
}
