using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9
{
    class Program
    {
        static void Main(string[] args)
        //4.1
        {
            Console.WriteLine("Введите число x");
            double x = Convert.ToDouble(Console.ReadLine());
            if (x > 0)
            {
                double x2 = Math.Pow(Math.Sin(x), 2);
                Console.WriteLine("Ответ" + x2);

            }
            else
            {
                Console.WriteLine("Введите число x");
                double x1 = Convert.ToDouble(Console.ReadLine());
                double x3 = 1 - 2 * Math.Sin(Math.Pow(x, 2));

            }
            Console.ReadKey();

            Console.WriteLine("Скрость  A в килметрах в ч");
            Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Скрость  B в килметрах в ч");
            Convert.ToDouble(Console.ReadLine());
            double A = Convert.ToDouble(Console.ReadLine());
            double B = Convert.ToDouble(Console.ReadLine());
            if (A > B)

            {
                Console.WriteLine("Скорост A большечем в B {0} КМ");
            }
            else
            {
                Console.WriteLine("Скорость A меньше чем в B {0} КМ");

            }
            Console.ReadKey();
        }
    }
}
