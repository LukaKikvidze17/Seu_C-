using System;

namespace MyNamespace
{
    class Program
    {
        static void Main()
        {
            Console.Write("U = ");
            double U = Convert.ToDouble(Console.ReadLine());
            Console.Write("R = ");
            double R = Convert.ToDouble(Console.ReadLine());
            if (R == 0)
            {
                Console.WriteLine("ნულზე გაყოფა არ შეიძლება");
            }
            else
            {
                double J = U / R;
                Console.WriteLine($"J = {J}");
            }
        }
    }
};

