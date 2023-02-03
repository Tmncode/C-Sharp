using System;
using static System.Console;


namespace WhippetBus
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] miles = { 0, 100, 300, 500 };
            double[] tickets = { 25.00, 40.00, 55.00, 70.00 };
            int x;
            int dInput;
            double tPrice = 0;

            string inputString;

            Write("Enter trip distance in miles: ");
            inputString = ReadLine();
            dInput = Convert.ToInt32(inputString);

            bool isValid = false;

            for (x = miles.Length -1; x >= 0 && !isValid; --x)
            {
                if(dInput >= miles[x])
                {
                    WriteLine("It will cost you {0} ", tickets[x].ToString("C"));
                    isValid = true;
                    tPrice = tickets[x];
                }

            }
            if (!isValid)
                WriteLine("Invalid");

            ReadLine();
        }

    }
}
