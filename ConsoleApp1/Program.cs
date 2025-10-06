using System;

namespace MyNamespace
{
    class Program
    {
        static void Main()
        {
            Console.Write("X = ");
            double x = Convert.ToDouble(Console.ReadLine());
            double y = (Math.Pow(Math.Sin(x), 3) + Math.Pow(Math.Cos(x), 12)) / Math.Exp(Math.Sqrt(x));
            Console.WriteLine($"y = {y}");
        }
    }
};