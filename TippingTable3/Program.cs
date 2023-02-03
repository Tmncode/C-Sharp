using System;
using static System.Console;

namespace TippingTable3
{
    class Program
    {
        static void Main(string[] args)
        {
            
            double DinnerPrice, tipRate, tip, LOWRATE, MAXRATE, MAXDINNER;
            const double TIPSTEP = 0.05;
            const double DINNERSTEP = 10.00;

            // ask user inputs
            Write("Enter the lowest tipping rate (in decimal form (5% = 0.05):  ");
            string lowrate = ReadLine();
            LOWRATE = Convert.ToDouble(lowrate);

            Write("Enter the highest tipping rate (in decimal form (20% = 0.20):  ");
            string highrate = ReadLine();
            MAXRATE = Convert.ToDouble(highrate);

            Write("Enter the lowest bill: $");
            string lowbill = ReadLine();
            DinnerPrice = Convert.ToDouble(lowbill);

            Write("Enter the highest bill: $");
            string highbill = ReadLine();
            MAXDINNER = Convert.ToDouble(highbill);

            // spacer
            WriteLine();
            
            Write("   Price");
            for (tipRate = LOWRATE; tipRate <= MAXRATE; tipRate += TIPSTEP)
                Write("{0, 8}", tipRate.ToString("F"));
            WriteLine();

            // create dashed line below header
            const int NUM_DASHES = 100;
            for (int x = 0; x < NUM_DASHES; ++x)
                Write("-");
            WriteLine();

            //display tip associated with price as a chart
            tipRate = LOWRATE;

            while (DinnerPrice <= MAXDINNER)
            {
                Write("{0, 8}", DinnerPrice.ToString("C"));
                while (tipRate <= MAXRATE)
                {
                    tip = DinnerPrice * tipRate;
                    Write("{0, 8}", tip.ToString("C"));
                    tipRate += TIPSTEP;
                }
                DinnerPrice += DINNERSTEP;
                tipRate = LOWRATE;
                WriteLine();
            }

            // stop program from automatically closing
            ReadLine();
             
        }
    }
}
