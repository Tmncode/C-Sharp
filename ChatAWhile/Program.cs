using System;
using static System.Console;


namespace ChatAWhile
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] areaCodes = { 262, 414, 608, 715, 815, 920 };
            double[] perMRates = { 0.07, 0.10, 0.05, 0.16, 0.24, 0.14 };
            int x;
            int validAreaCode;

            string inputString, input;
            
            double totalCharge = 0, inputLength;
            double areaCodesPerMinuteRate = 0;

            Write("Enter zipcode: ");
            inputString = ReadLine();
            validAreaCode = Convert.ToInt32(inputString);            

            Write("Enter length of time: ");
            input = ReadLine();
            inputLength = Convert.ToDouble(input);

            bool isValid = false;
            x = 0;

            for (x = 0; x < areaCodes.Length && !isValid; ++x)
            {
                if (validAreaCode == areaCodes[x])
                {
                    isValid = true;
                    areaCodesPerMinuteRate = perMRates[x];
                    totalCharge = areaCodesPerMinuteRate * inputLength;
                }
            }
            if (isValid)
            {
                WriteLine(" The call was {0} long and it will cost you {1}", inputLength, totalCharge);
            }
            else
                WriteLine("We do not support such zipcode, Sorry!! ");
            ReadLine();
        }
        
    }
}
