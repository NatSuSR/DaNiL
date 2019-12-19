using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication22
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите число  ");
            double a = Double.Parse(Console.ReadLine());

            double y = Function(a);
            Console.WriteLine("f(a) = {y}");
        }

        private static double Function(double x)
        {
            if (x <= -1)
                return Math.Pow(x, -2);
            else if (x > -1 && x <= 2)
                return Math.Pow(x, 2);
            else
               return 4;
        }
    }
}
