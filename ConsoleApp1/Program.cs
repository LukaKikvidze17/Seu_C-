using System;

namespace MyNamespace
{
    class Program
    {
        static void Main()
        {
            Console.Write("y = ");
            double y = Convert.ToDouble(Console.ReadLine());
            Console.Write("x = ");
            double x = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(y = x + 1 + Math.Pow(x,2) / 2);
        }
    }
};

