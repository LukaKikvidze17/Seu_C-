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
            double y = Math.Sqrt(1 + Math.Sqrt(Math.Abs(x)));
            Console.WriteLine("y == " + y);
        }
    }
}; 