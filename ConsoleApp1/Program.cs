using System;

namespace MyNamespace
{
    class Program
    {
        static void Main()
        {
            Console.Write("x = ");
            double x = Convert.ToDouble(Console.ReadLine());
            double y = 1 + Math.Abs(x) + (1 + Math.Abs(x));
            Console.WriteLine($"y = {y}");
        }
    }
};

