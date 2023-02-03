using System;
using static System.Console;


namespace PaintingEstimate
{
    class Program
    {
        static void Main(string[] args)
        {            
            WriteLine("The length of the room in feet:");
            double length = double.Parse(ReadLine());

            WriteLine("The width of the room in feet:");
            double width = double.Parse(ReadLine());
            double cost = PaintCalculation(length, width);

            WriteLine("The floor is {0} feet in length and area {1} feet in width", length, width);
            WriteLine("Your total estimate cost is {0}", cost.ToString("C"));
            ReadLine();
        }
        private static double PaintCalculation(double length, double width)
        {
            double squareFootage = (length) * (width);
            double cost = squareFootage * 6;
            return cost;

        }
    }
}
