using System;
using static System.Console;


namespace CheckZip
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] zipCodes = {40475, 40473, 40476, 40481, 40484,
                             40480, 40471, 40486, 40488, 40489 };
            int x;
            string entryZip;
            

            WriteLine("Enter a Zip code for delivery ");
            entryZip = ReadLine();

            for(x = 0; x < zipCodes.Length; ++x)
            {
                if (x == zipCodes.Length)
                    WriteLine("Delivery to {0} is ok", entryZip);
                
            }
            if (x != zipCodes.Length)
            {
                WriteLine("Sorry not within company {0} area ", entryZip);
            }
            ReadLine();
        }
    }
}
