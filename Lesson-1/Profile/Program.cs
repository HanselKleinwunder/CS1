using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Выполнил: Скворцов Александр
 * Написать программу «Анкета». 
 * Последовательно задаются вопросы (имя, фамилия, возраст, рост, вес). 
 * В результате вся информация выводится в одну строчку:
 * используя склеивание;
 * используя форматированный вывод;
 * используя вывод со знаком $.
*/

namespace Profile
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name, lastname;
            int age, weight, height;

            Console.Write("Пожалуйста, введите ваше имя: ");
            name = Console.ReadLine();
            Console.Write("Пожалуйста, введите вашу фамилию: ");
            lastname = Console.ReadLine();
            Console.Write("Пожалуйста, введите ваш возраст: ");
            age = int.Parse(Console.ReadLine());
            Console.Write("Пожалуйста, введите ваш вес: ");
            weight = int.Parse(Console.ReadLine());
            Console.Write("Пожалуйста, введите ваш рост: ");
            height = int.Parse(Console.ReadLine());

            Console.WriteLine("Склеивание: " + name + " " + lastname + ", " + age + ", " + weight
                + ", " + height);
            Console.WriteLine("Форматированный вывод: {0} {1}, {2}, {3}, {4}", name, lastname,
                age, weight, height);
            Console.WriteLine($"Вывод со знаком $: {name} {lastname}, {age}, {weight}, {height}");

            Console.ReadKey();
        }
    }
}
