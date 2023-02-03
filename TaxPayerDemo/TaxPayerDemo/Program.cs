using System;
using static System.Console;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaxPayerDemo
{
    class TaxPayer
    {
        // Instance Fields
        private string socialSecurityNumber;
        private double grossIncome;
        private double taxOwed;

        // Properties
        public double GrossIncome
        {
            get
            {
                return grossIncome;
            }
            set
            {
                grossIncome = value;
                if (grossIncome < 30000)
                {
                    taxOwed = grossIncome * .15;
                }
                else
                {
                    taxOwed = grossIncome * .28;
                }
            }
        }
        public string SocialSecurityNumber
        {
            get
            {
                return socialSecurityNumber;
            }
            set
            {
                socialSecurityNumber = value;
            }
        }
        public double TaxOwed
        {
            get
            {
                return taxOwed;
            }
        }
            
        static void Main(string[] args)
        {
            TaxPayer[] taxArr = new TaxPayer[10];
            for (int x = 0; x < taxArr.Length; x++)
            {
                taxArr[x] = new TaxPayer();

                // Input
                Console.WriteLine("Enter your gross income.");
                taxArr[x].GrossIncome = double.Parse(Console.ReadLine());

                Console.WriteLine("Enter your Social Security Number (SSN)");
                taxArr[x].SocialSecurityNumber = Console.ReadLine();

                // Output 
                Console.WriteLine(taxArr[x]);
                Console.WriteLine("Social Security Number is: " + taxArr[x].SocialSecurityNumber);
                Console.WriteLine("Gross income is: " + taxArr[x].GrossIncome.ToString("C"));
                Console.WriteLine("Taxes owed for this year are: " + taxArr[x].TaxOwed.ToString("C"));
                Read();
            }
        }
    }
}
