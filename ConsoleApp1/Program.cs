using System;

class Program
{
    static void Main()
    {
        Console.Write("x = ");
        string text = Console.ReadLine();
        if (double.TryParse(text, out double number))
        {
            if (number > 0)
            {
                Console.WriteLine("რიცხვი დადებითია");
            }
            else if (number < 0)
            {
                Console.WriteLine("რიცხვი უარყოფითია");
            }
            else
            {
                Console.WriteLine("რიცხვი 0-ის ტოლია");
            }
        }
        else
        {
            Console.WriteLine("ჩაწერი მხოლოდ რიცხვი");
        }
    }
}