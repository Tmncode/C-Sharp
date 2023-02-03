using System;
using static System.Console;



namespace CheckZips
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] areaCodes = { 45216, 85435, 75461, 36547, 65874, 15487, 32549, 85722, 75462, 46587 };
            int validZipCode;
            string inputString;

            Write("Enter Zip code number ");
            inputString = ReadLine();
            validZipCode = Convert.ToInt32(inputString);
            
            bool isValid = false;
            for (int x = 0; x < areaCodes.Length; ++x)
            {

                if (validZipCode == areaCodes[x])
                {
                    WriteLine("Zip code is in company's delivery area  ");
                    isValid = true;
                }

            } 
            if (!isValid)
            {
               WriteLine("Zip code is not in company delivery area Sorry  ");
            }
            ReadLine();
        }
    }
}
