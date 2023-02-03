using System;
using static System.Console;

namespace HomeSales
{
    class Program
    {

        static void Main(string[] args)
        {
            //initial == "D" || initial == "d" || initial == "E" || initial == "e" || initial == "F" || initial == "f"

            WriteLine("Salespeople include:\nDenielle\nEdward\nFrancis");
            string initial = "";
            //WriteLine("initial={0}", initial);
            double salesAmount = 0.00;
            double dAmount = 0.00;
            double eAmount = 0.00;
            double fAmount = 0.00;
            double grandTotal = 0.00;
            

            Write("\nEnter a saleperson's first initial (or z to quit): ");
            initial = ReadLine().ToLower();
            while(initial != "z")
            {
                

                if (initial == "d")
                
                {
                    Write("Enter sales amount for Denielle: ");
                    salesAmount = Convert.ToDouble(ReadLine());
                    dAmount += salesAmount;
                }
                else if (initial == "e")
                {
                    Write("Enter sales amount for Edward: ");
                    salesAmount = Convert.ToDouble(ReadLine());
                    eAmount += salesAmount;
                }
                else if (initial == "f")
                {
                    Write("Enter sales amount for Francis: ");
                    salesAmount = Convert.ToDouble(ReadLine());
                    fAmount += salesAmount;
                }
                else
                    WriteLine("Invalid entry");
                
                
                Write("\nEnter a saleperson's first initial (or z to quit): ");
                initial = ReadLine().ToLower();
                
            }
            grandTotal = dAmount + eAmount + fAmount;
            

            WriteLine("\nDanielle's total sale Amount: {0:c}"
                    + "\nEdward's total sale Amount: {1:c}"
                    + "\nFrancis' total sale Amount: {2:c}"
                    + "\nGrand Total: {3:c}", dAmount, eAmount, fAmount, grandTotal);

            if (dAmount > eAmount && dAmount > fAmount)
            {
                WriteLine("Danielle has the highest amount {0:c}", dAmount);
            }
            if (eAmount > dAmount && eAmount > fAmount)
            {
                WriteLine("Edward has the highest amount {0:c}", eAmount);
            }
            if (fAmount > dAmount && fAmount > eAmount)
            {
                WriteLine("Francis has the highest amount {0:c}", fAmount);
            }
                
            ReadLine();
        }
    }
}
