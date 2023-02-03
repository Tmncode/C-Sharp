using System;
using static System.Console;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindSquareRoot
{
    class Program
    {
        
        static void Main(string[] args)
        {
            bool isValid = false;
            double number = 0, sqrt = 0;
            while (!isValid)
            {
                Write("Enter a valid number: ");
                isValid = double.TryParse(ReadLine(), out number);
            }
            try
            {
                if (number < 0)
                {
                    throw new ApplicationException("Can't be a negative number");
                }
                else
                {
                    sqrt = Math.Sqrt(number);
                }
            }
            catch (ApplicationException e)
            {
                WriteLine(e.Message);
            }
            WriteLine("Square Root of {0} is {1}", number, sqrt);
            ReadKey();
        }
    }
}
