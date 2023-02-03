using System;
using static System.Console;


namespace SumInts
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = 0, total = 0;
            const int LIMIT = 999;

            string input;

            Write("User enter any number   ");

            input = ReadLine();
            number = Convert.ToInt32(input);

            while(!(number == LIMIT))
            {
                total += number;
                WriteLine("{0}", total);
                //for(number = 0; number <= LIMIT; ++number)
                //{
                //    WriteLine("{0}", number);
                //}
                Write("User enter any number   ");

                input = ReadLine();
                number = Convert.ToInt32(input);
            }

                WriteLine("Goodbye!");
            ReadLine();
        }
    }
}
