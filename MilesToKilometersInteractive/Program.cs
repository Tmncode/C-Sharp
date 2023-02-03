//Written by <Tam M. Nguyen>
//Written on <11/5/19>
using System;
using static System.Console;

namespace MilesToKilometersInteractive
{
    class Program
    {
        static void Main(string[] args)
        {
            double Miles;
            double Kilometer;
            Write("enter amount of miles  ");
            Miles = Convert.ToDouble(ReadLine());
            Kilometer = 1.6 * Miles;
            WriteLine("{0} Miles into Kilometers is {1}", Miles, Kilometer);

        }
    }
}
