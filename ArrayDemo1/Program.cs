using System;
using static System.Console;

namespace ArrayDemo1
{
    class ArrayDemo1
    {
        static void Main()
        {
            double[] payRate = { 6.00, 7.35, 8.12, 12.45 };

            for (int x = 0; x < payRate.Length; ++x)
            {
                WriteLine("Pay rate {0} is {1}",
                    x, payRate[x].ToString("C"));
            }
            WriteLine("\nPress the Enter key to close program.");
            ReadLine();
        }
    }
}
