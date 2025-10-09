using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main()
        {
            bool x1 = false;
            bool x2 = false;
            bool x3 = true;
            bool x4 = true;

            bool y = (x1 || !x2) && (x3 || x4);
            Console.WriteLine(y);
        }
    }
};

