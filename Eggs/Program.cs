//Written by <Tam M. Nguyen>
//Written on <11/6/2019>

using System;
using static System.Console;

namespace Eggs
{
    class Program
    {
        static void Main(string[] args)
        {

            int chicken1 = 35, chicken2 = 29, chicken3 = 30, chicken4 = 33,
                sum, dozen, remainder;

            sum = chicken1 + chicken2 + chicken3 + chicken4;
            dozen = sum / 12;
            remainder = sum % 12;

            Console.WriteLine("I have 4 chicken laid {0} eggs this month.  That is {1} dozen and {2} remaining.",
                 chicken1 + chicken2 + chicken3 + chicken4, dozen, remainder); 

            ReadLine();
        }
    }
}
