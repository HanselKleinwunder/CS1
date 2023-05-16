using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Выполнил: Скворцов Александр
 * Ввести вес и рост человека. 
 * Рассчитать и вывести индекс массы тела (ИМТ) по формуле I=m/(h*h); 
 * где m — масса тела в килограммах, h — рост в метрах
*/

namespace BodyMassIndex
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double mass, height, BMI;

            Console.Write("Пожалуйста, введите ваш рост в см: ");
            height = double.Parse(Console.ReadLine());
            Console.Write("Пожалуйста, введите ваш вес в кг: ");
            mass = double.Parse(Console.ReadLine());

            height /= 100;

            BMI = mass / (height * height);

            Console.Write("Индекс массы тела: {0:F0}", BMI);

            Console.ReadKey();
        }
    }
}
