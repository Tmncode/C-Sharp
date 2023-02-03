using System;
using static System.Console;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BounsCalculation
{
    class Program
    {
        private static double calcGross(double hours, double rate, out double bonus)
        {
            double gross = hours * rate;
            if (hours >= 40)
                bonus = 50;
            else
                bonus = 0;
            return gross;
        }
        private static double calcTotalPay(double gross, double bonus)
        {
            double total = gross + bonus;
            return total;
        }
        static void Main()
        {
            double hours = 40;
            double rate = 15.00;
            double bonus = 0;
            double totalPay;
            totalPay = calcTotalPay(calcGross(hours, rate, out bonus), bonus);

            WriteLine("Total pay is {0:c2}", hours * rate, totalPay);
            WriteLine("Your bonus is {0:c2}", bonus);
            WriteLine("Your total pay with bonus is {0:c2}", totalPay);
            Read();
        }
    }
}
