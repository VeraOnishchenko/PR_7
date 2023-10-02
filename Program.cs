//**********************************************************
//* Практическая работа №7                                 *
//* Выполнил: Онищенко В.И., группа 2ИСП                   *
//* Задание: составление программы разветвляющего цикла    *
//**********************************************************

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pr_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Практическая работа №7";// заголовок консоли
            Console.WriteLine("Здравствуйте!");

            {
                int n; //объявление переменных
                double v1, v2, v3, v4, factorial = 1, a = 0;
                Console.Write("Введите n = ");
                n = Convert.ToInt32(Console.ReadLine());

                for (int i = 1; i <= n; i++)
                {
                    v1 = Math.Pow(-1, n);
                    v2 = Math.Pow(2, n);
                    v3 = v1 * v2;
                    factorial *= i;
                    a = (v3 / factorial);
                }
                v4 = Math.Abs(a);
                if (v4 < 0.0001)
                {
                    Console.WriteLine($"Модуль an < ε, М = {v4}");
                }
                else
                {
                    Console.WriteLine($"Модуль an > ε, Результат: {a}");
                }
                Console.WriteLine("До свидания!");
                Console.ReadKey();
            }

            }
    }
}
