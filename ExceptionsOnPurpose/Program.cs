using System;
using static System.Console;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionsOnPurpose3
{
    class ExceptionsOnPurpose
    {
        static void Main(string[] args)
        {
            int answer = 0;
            int result;
            int zero = 0;

            try
            {
                Write("Enter an integer >> ");
                answer = Convert.ToInt32(ReadLine());
                result = answer / zero;
            }

            catch(FormatException)
            {
                WriteLine("You did not enter and integer");
            }
            catch(DivideByZeroException)
            {
                WriteLine("This is not your fault.");
                WriteLine("You entered the integer correctly.");
                WriteLine("The program divides by zero.");
            }
            WriteLine("The answer is " + answer);
            Read();
        }
    }
}
