using System;
using static System.Console;


namespace ConvertQuartsToLiters
{
    class Program
    {
        static void Main(string[] args)
        {           
            double quarts = double.Parse(ReadLine());
            double liters = ConversionCalcQuartsIntoLiters(quarts);
            WriteLine("Enter a number of quarts and we'll calculate how many quarts equal to liters.");
          
            WriteLine("{0} quarts is total to {1} liters", quarts, liters);
           
            ReadLine();
        }
        private static double ConversionCalcQuartsIntoLiters(double quarts)
        {
            double quartz = .966353;
            double liters = quarts * quartz;
            WriteLine("A quart is {0} liters", quartz);

            return liters;
        }
        

    }
}
