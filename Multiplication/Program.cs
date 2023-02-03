using System;
using static System.Console;


namespace Multiplication
{
    class Program
    {
        static void Main(string[] args)
        {
            Write("Enter a number : ");
            string input = ReadLine();
            int num;
            int.TryParse(input, out num);
            WriteLine();

            DisplayMultiplicationTable(num);
            ReadLine();
        }
        private static void DisplayMultiplicationTable(int num)
        {
            for(int i = 2; i <= 10; i++)
            {
                WriteLine("{0} * {1, -2} = {2}", num, i, num * i);
            }
        }
    }
}
