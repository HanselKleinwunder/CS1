using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Выполнил: Скворцов Александр
 * Написать программу, которая подсчитывает расстояние между точками с координатами 
 * x1, y1 и x2,y2 по формуле r=Math.Sqrt(Math.Pow(x2-x1,2)+Math.Pow(y2-y1,2). 
 * Вывести результат, используя спецификатор формата .2f (с двумя знаками после запятой);
 *  *Выполните предыдущее задание, оформив вычисления расстояния между точками в виде метода;
 */


namespace DistanceBetweenPoints
{
    internal class Program
    {
        static double DistancePoints(double x1, double y1, double x2, double y2)
        {
            return Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
        }

        static void Main(string[] args)
        {
            double x1, y1, x2, y2, DBP;

            Console.Write("Пожалуйста, введите то x1: ");
            x1 = double.Parse(Console.ReadLine());
            Console.Write("Пожалуйста, введите то y1: ");
            y1 = double.Parse(Console.ReadLine());
            Console.Write("Пожалуйста, введите то x2: ");
            x2 = double.Parse(Console.ReadLine());
            Console.Write("Пожалуйста, введите то y2: ");
            y2 = double.Parse(Console.ReadLine());

            DBP = DistancePoints(x1, y1, x2, y2);

            Console.Write("Для точек с координатами: {0}, {1}, {2}, {3}. " +
                "Расстояние равняется: ", x1, y1, x2, y2);
            Console.Write("{0:F2}", DBP);

            Console.ReadKey();
        }
    }
}
