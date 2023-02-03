using System;
using static System.Console;

namespace ProjectedRaisesInteractive
{
    class Program
    {
        static void Main(string[] args)
        {
            double salaries;
            
            Write("Enter salaries amount  ");
            salaries = Convert.ToDouble(ReadLine());
            salaries += 0.50 * salaries;
            WriteLine("{0} is the raise", salaries);

        }
    }
}
