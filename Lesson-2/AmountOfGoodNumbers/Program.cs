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

            for (int i = 0; i < n.Length; i++)
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
            DateTime dateTime = DateTime.Now;
            int count = 0, number;

            Console.Write("Вас привествует программа подсчёта количества хороших чисел.\n" +
                "Минимальное число диапазона 1, максимальное 1 000 000 000\n" +
                "Введите последнее число диапазона: ");
            number = int.Parse(Console.ReadLine());

            for (int i = 1; i < number; i++)
            {
                if (goodNumbers(i))
                {
                    count++;
                }
            }

            Console.WriteLine("Количество „хороших“ чисел в диапазоне от 1 до {0}: {1}", number, count);
            Console.WriteLine("Время, затраченное на выполнение данной операции: {0}", DateTime.Now - dateTime);
            Console.ReadLine();
        }
    }
}
