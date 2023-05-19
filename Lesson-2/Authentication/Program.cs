using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

/*
 * Выполнил: Скворцов Александр
 * Реализовать метод проверки логина и пароля. 
 * На вход подается логин и пароль. 
 * На выходе истина, если прошел авторизацию, и ложь, если не прошел 
 * (Логин: root, Password: GeekBrains). 
 * Используя метод проверки логина и пароля, написать программу: 
 * пользователь вводит логин и пароль, программа пропускает его дальше или не пропускает. 
 * С помощью цикла do while ограничить ввод пароля тремя попытками.
 */

namespace Authentication
{
    internal class Program
    {
        static bool Authentication(string login, string password)
        {
            if (login == "root" && password == "GeekBrains")
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
            int count = 3;
            string login, password;

            do
            {
                Console.Write("Пожалуйста, введите ваш логин: ");
                login = Console.ReadLine();
                Console.Write("Пожалуйста, введите ваш пароль: ");
                password = Console.ReadLine();

                if(Authentication(login, password))
                {
                    Console.WriteLine("Добро пожаловать!");
                    break;
                }
                else
                {
                    count--;
                    Console.WriteLine("Неправильно введёт логин или пароль.\nОсталось попыток " + count);
                }

            } while (count > 0);

            Console.ReadLine();
        }
    }
}
