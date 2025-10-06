using System;
using System.Numerics;

namespace MyNamespace
{
    class Program
    {
        static void Main()
        {
            Console.Write("x = ");
            double x = Convert.ToDouble(Console.ReadLine());
            Console.Write("z = ");
            double z = Convert.ToDouble(Console.ReadLine());
            double y = (Math.Pow(x, 2) + Math.Pow(z, 2)) / (2 * (1 - (Math.Pow(x, 2) - Math.Pow(z, 2))));
            Console.WriteLine(y);
        }
    }
}; 