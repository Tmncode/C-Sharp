using System;
using static System.Console;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiscountDelegateDemo
{
    delegate void DiscountDelegate(ref double saleAmount);
    class DiscountDelegateDemo2
    {      
        static void Main(string[] args)
        {
            double saleAmount;
            char code;
            DiscountDelegate firstDel, secondDel, thirdDel;
            firstDel = new DiscountDelegate(StandardDiscount);
            secondDel = new DiscountDelegate(PreferredDiscount);
            thirdDel = firstDel;
            thirdDel += secondDel;
            Write("Enter amount of sale: ");
            saleAmount = Convert.ToDouble(ReadLine());
            Write("Enter S for standard discount, "
                + "P for Preferred discount, " +
                "\nor X for eXtreme discount ");
            code = Convert.ToChar(ReadLine());         
            if (code == 'S')
                firstDel(ref saleAmount);
            else
                if (code == 'P')
                secondDel(ref saleAmount);
            else
                thirdDel(ref saleAmount);
            WriteLine("New sale amount is {0}",
                saleAmount.ToString("C2"));
            ReadLine();
        }
        public static void StandardDiscount(ref double saleAmount)
        {
            const double DISCOUNT_RATE = 0.05;
            const double CUTOFF = 1000.00;
            double discount;
            if (saleAmount >= CUTOFF)
                discount = saleAmount * DISCOUNT_RATE;
            else
                discount = 0;
            saleAmount -= discount;
        }
        public static void PreferredDiscount(ref double saleAmount)
        {
            const double SPECIAL_DISCOUNT = 0.10;
            double discount = saleAmount * SPECIAL_DISCOUNT;
            saleAmount -= discount;
        }
    }
}
