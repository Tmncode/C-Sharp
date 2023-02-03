using System;
using static System.Console;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaxPayerDemo
{
    class Program
    {
        public static void Main()
        {
            Taxpayer[] arrayTax = new Taxpayer[2];
            
            int x;

            for (x = 0; x < arrayTax.Length; ++x)
            {
                arrayTax[x] = new Taxpayer();

                WriteLine("Enter your Social Security Number.");
                arrayTax[x].SSN = ReadLine();

                WriteLine("Enter your yearly income salary.");
                arrayTax[x].GrossIncome = double.Parse(ReadLine());
                WriteLine();

                WriteLine(" Your Social Security Number {0}:\n Your yearly gross income {1}:\n Your total tax deduction {2}\n",
                    arrayTax[x].SSN, arrayTax[x].GrossIncome.ToString("c"), arrayTax[x].Tax.ToString("c"));
               
            }
            Read();
        }
        class Taxpayer
        {

            public string ssn;//{ get; set; }
            public double grossIncome;//{get; set; }
            public double tax;//{ get; set; }

          
            public string SSN
            {
                get
                {
                    return this.ssn;

                }
                set
                {
                    this.ssn = value;
                    
                }
            }
            
            public double GrossIncome 
            {
                
                get
                {
                    return this.grossIncome;

                }
                set
                {
                    this.grossIncome = value;
                    if(grossIncome < 30000)
                    {
                        tax = grossIncome * .15;
                    }
                    else
                    {
                        tax = grossIncome * .28;
                    }
                    

                }
            }
            public double Tax
            {
                get
                {
                    return tax;
                }
            }
        }
    }
}
