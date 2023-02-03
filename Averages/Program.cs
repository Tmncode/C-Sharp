using System;
using static System.Console;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Averages
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>();

            string input;

            Write("Enter a numbers: " + Environment.NewLine);

            while (true)
            {
                input = ReadLine();
                int number = -1;
                bool success = int.TryParse(input, out number);

                if (success)
                    numbers.Add(number);
                else
                    break;  
            }

            
            WriteLine("Count:" + numbers.Count);
            
            WriteLine("Average:" + numbers.Average());
            ReadLine();
        }

    }
}
