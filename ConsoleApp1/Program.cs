using System;

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
            double y = (Math.Abs(x) - Math.Abs(z)) / (1 + Math.Log(x));
            Console.WriteLine($"y = {y}");
        }
    }
};

