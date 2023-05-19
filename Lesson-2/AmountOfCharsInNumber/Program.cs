using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Выполнил: Скворцов Александр
 * Написать метод подсчета количества цифр числа.
*/


namespace AmountOfCharsInNumber
{
    internal class Program
    {
        static int AmountOfChars(string number)
        {
            return number.Length;
        }

        static void Main(string[] args)
        {
            string number;

            Console.Write("Пожалуйста, введите любое число: ");
            number = Console.ReadLine();

            Console.Write("Количество символов в ведённом числе: "
                + AmountOfChars(number));

            Console.ReadLine();
        }
    }
}
