using System;
using static System.Console;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntegerFacts
{
    class Program
    {       
        private static string _STOP = "STOP";
        private static int _MAX_SIZE = 20;

        static void Main(string[] args)
        {
            List<int> numbers = FillList();

            foreach (int number in numbers)
                    Write("{0, 4}", number);

            WriteLine();
            WriteLine("The list has {0} values", numbers.Count);
            WriteLine("The highest value is {0}", numbers.Max());
            WriteLine("The lowest value is {0}", numbers.Min());
            WriteLine("The sum of the array is {0}", numbers.Sum());
            WriteLine("The average is {0}", numbers.Average());
            ReadKey();

        }

        private static List<int> FillList()
        {
            List<int> numbers = new List<int>();
            int value;
            int count = 0;
            do
            {
                Write("Enter a number 20 times or {0} to exit: ", _STOP);
                string line = ReadLine();
                if (line == _STOP)
                    break;

                if (int.TryParse(line, out value))
                {
                    numbers.Add(value);
                    count++;
                }
                else
                {
                    WriteLine("Error invalid entry try again.");
                }
            } while (count < _MAX_SIZE);

            return numbers;
        }
    }    
}

