using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Выполнил: Скворцов Александр
 * Написать программу, которая запрашивает массу и рост человека, 
 * вычисляет его индекс массы и сообщает, нужно ли человеку похудеть, 
 * набрать вес или все в норме.
 * *Рассчитать, на сколько кг похудеть или сколько кг набрать для нормализации веса.
 */

namespace BodyMassIndex
{
    internal class Program
    {
        static string Check(double BMI, double height)
        {
            string result = "";

            if (BMI < 16)
            {
                double norm = (18.5 - BMI) * (height * height);
                result = string.Format("выраженный дефицит массы тела! " +
                    "Необходимо набрать {0:F1} кг.", norm);
            }
            else if (BMI >= 16 && BMI < 18.5)
            {
                double norm = (18.5 - BMI) * (height * height);
                result = string.Format("недостаточная масса тела! " +
                    "Необходимо набрать {0:F1} кг.", norm);
            }
            else if(BMI >= 18.5 && BMI < 24.9)
            {
                result = "норма!";
            }
            else if (BMI >= 25 && BMI < 30)
            {
                double norm = (30 - BMI) * (height * height);
                result = string.Format("избыточная тела! " +
                    "Необходимо сбросить {0:F1} кг.", norm);
            }
            else if (BMI >= 30 && BMI < 35)
            {
                double norm = (30 - BMI) * (height * height);
                result = string.Format("ожирение первой степени! " +
                    "Необходимо сбросить {0:F1} кг.", norm);
            }
            else if (BMI >= 35 && BMI < 40)
            {
                double norm = (40 - BMI) * (height * height);
                result = string.Format("ожирение второй степени! " +
                    "Необходимо сбросить {0:F1} кг.", norm);
            }
            else if (BMI >= 40)
            {
                double norm = (40 - BMI) * (height * height);
                result = string.Format("ожирение третьей степени! " +
                    "Необходимо сбросить {0:F1} кг.", norm);
            }

            return result;
        }

        static void Main(string[] args)
        {
            double mass, height, BMI;

            Console.Write("Пожалуйста, введите ваш рост в см: ");
            height = double.Parse(Console.ReadLine());
            Console.Write("Пожалуйста, введите ваш вес в кг: ");
            mass = double.Parse(Console.ReadLine());

            height /= 100;

            BMI = mass / (height * height);

            Console.WriteLine("Индекс массы тела: {0:F1}", BMI);
            Console.WriteLine("У вас {0}", Check(BMI, height));

            Console.ReadLine();
        }
    }
}
