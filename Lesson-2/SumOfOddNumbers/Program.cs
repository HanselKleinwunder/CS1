using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Выполнил: Скворцов Александр
 * С клавиатуры вводятся числа, пока не будет введен 0. 
 * Подсчитать сумму всех нечетных положительных чисел.
 */

namespace SumOfOddNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int oddNumbers = 0;

            Console.WriteLine("Вас приветствует программа подсчёта нечётных положительных чисел.\n" +
                "Посредством нажатия клавиши Enter, вводите числа по одному.\n" +
                "Если необходимо закончить подсчёт, введите 0.");

            while (true)
            {
                Console.Write("Пожалуйста, введите число: ");
                int numbers = int.Parse(Console.ReadLine());

                if (numbers != 0)
                {
                    if (numbers % 2 == 1)
                    {
                        oddNumbers = oddNumbers + numbers;
                    }
                }
                else
                {
                    break;
                }
            }

            Console.Write("Сумма всех нечётных положительных цифр: " + oddNumbers);

            Console.ReadLine();
        }
    }
}
