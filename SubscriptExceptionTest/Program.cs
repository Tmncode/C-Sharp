using System;
using static System.Console;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SubscriptExceptionTest
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] array = { 20.5, 44.57, 32.1, 46.2, 89.48, 67.1, 12.92, 14.4, 22.24, 13.18,
                7.74, 18.7, 88.20, 3.3, 50.1, 60.61, 71.8, 55.1, 91.44, 30.9 };
            int subscript = 0;
            while (subscript != 99)
                try
                {
                    WriteLine("To exit program enter number 99");
                    Write("Enter a number to see the value in that position. ");
                    
                    subscript = Convert.ToInt32(ReadLine());
                    if (subscript != 99)
                    {
                    }
                    if (subscript == 99)
                    {
                    }

                    double arrayVal = array[subscript];
                    WriteLine("The value at index {0} is {1}.", subscript, arrayVal);
                    WriteLine();
                }
                catch (FormatException s) { WriteLine(s.Message + " You did not enter a number. "); }
                catch (IndexOutOfRangeException e)
                {
                    WriteLine(e.Message + "\nPlease enter a number from 0 thru 19 to get position.");
                    WriteLine();
                }
        }
    }
}
