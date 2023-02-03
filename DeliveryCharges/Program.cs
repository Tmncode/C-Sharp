using System;
using static System.Console;


namespace DeliveryCharges
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] areaCodes = { 45216, 85435, 75461, 36547, 65874, 15487, 32549, 85722, 75462, 46587 };
            double[] deliveryCharges = { 5.50, 6.75, 7.95, 9.00, 12.00, 13.00, 14.50, 19.00, 20.25, 25.00 };
            double validZipCode;           
            string inputString;
            int x;

            Write("Enter Zip code number charges will be display according to area code: ");
            inputString = ReadLine();
            validZipCode = Convert.ToInt32(inputString);
            
            bool isValid = false;
            for (x = 0; x < areaCodes.Length && !isValid; ++x)
            {

                if (validZipCode == areaCodes[x])
                {
                    WriteLine("Zip code is in company's delivery area.  ", areaCodes[x].ToString());
                    WriteLine("price {0}", deliveryCharges[x].ToString("C"));
                    isValid = true;
                    validZipCode = deliveryCharges[x];
                }

            }

            if (!isValid)
            {
                WriteLine("Company does not deliver to the requested zip code, Sorry!!  ");
            }
            ReadLine();
        }
    }
}
