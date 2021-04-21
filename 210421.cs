using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp13
{
    class Program
    {
        static void Main(string[] args)
        {//Даны тристороны треугольника Вычислить явл ли треугольник прямоугольником
            int a, b, c;
            string temp = " ";
            //a
            Console.WriteLine("Введите число A");
            temp = Console.ReadLine();
            a = Convert.ToInt32(temp);
            //b

            Console.WriteLine("Введите число B");
            temp = Console.ReadLine();
            b = Convert.ToInt32(temp);
            //c
            Console.WriteLine("Ввдите число C");
            temp = Console.ReadLine();
            c = Convert.ToInt32(temp);
            if (a * a + b * b == c * c)
            {
                Console.WriteLine("Этот тругол прямоугольный");
            }
            else
            {
                Console.WriteLine("Этот треугольникт непрямоугольный");
            }
            Console.ReadKey();
            //Найти площадь данного треугольника по формулу Герона
            {
                Console.WriteLine("Ввдите число q w e r ");
                double q = double.Parse(Console.ReadLine());
                double w = double.Parse(Console.ReadLine());
                double e = double.Parse(Console.ReadLine());
                double r = double.Parse(Console.ReadLine());
                double s = Math.Sqrt((r * (r - q) * (r - w) * (r - e)));
                Console.Write($"Ответ: {s}");
            }
                Console.ReadKey();







            }
        }
    }

