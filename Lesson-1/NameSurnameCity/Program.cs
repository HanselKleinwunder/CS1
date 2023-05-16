using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
* Выполнил: Скворцов Александр
* а) Написать программу, которая выводит на экран ваше имя, фамилию и город проживания.
* б) Сделать задание, только вывод организуйте в центре экрана
* в) Сделать задание б с использованием собственных методов 
* (например, Print(string ms, int x,int y)
*/


namespace NameSurnameCity
{
    internal class Program
    {
        static void Position(string[] info, int x, int y)
        {
            for (int i = 0; i < info.Length; i++)
            {
                Console.SetCursorPosition(x, y + i);
                Console.WriteLine(info[i]);
            }
        }

        static void Main(string[] args)
        {
            string name, surname, city;

            Console.Write("Пожалуйста, введите ваше имя: ");
            name = Console.ReadLine();
            Console.Write("Пожалуйста, введите вашу фамилию: ");
            surname = Console.ReadLine();
            Console.Write("Пожалуйста, введите ваш город проживания: ");
            city = Console.ReadLine();

            string[] profile = { name, surname, city };

            Position(profile, 50, 12);

            Console.ReadLine();
        }
    }
}
