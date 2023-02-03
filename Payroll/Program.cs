//Written by <Tam M. Nguyen>
//Written on <11/6/2019>

using System;
using static System.Console;

namespace Payroll
{
    class Program
    {
        static void Main(string[] args)
        {
            string name;
            string ssn;
            double payRate;
            double hoursWorked;
            double grossPay;
            double fedTotal, stateTotal;
            double netPay;
            double fedTaxRate = 0.15;
            double stateTaxRate = 0.05;

            //get input
            Write("Enter your name: ");
            name = ReadLine();
            Write("\nSocial Security number is: ");
            ssn = ReadLine();
            Write("\nHourly pay rate is: ");
            payRate = Convert.ToDouble(ReadLine());
            Write("\nHours worked were: ");
            hoursWorked = Convert.ToDouble(ReadLine());
            Write("\nPayroll Summary for: ");

            //calculate
            grossPay = hoursWorked * payRate;
            fedTotal = grossPay * fedTaxRate;
            stateTotal = grossPay * stateTaxRate;
            netPay = grossPay - (fedTotal + stateTotal);

            //Give output
            WriteLine("");
            WriteLine("Name: {0}    SSN: {1}", name, ssn);
            WriteLine("You worked {0} hours at ${1} per hour", hoursWorked, payRate);
            WriteLine("");
            WriteLine("{0,-20}  {1,9}", "Your gross pay is", grossPay.ToString("C"));
            WriteLine("{0,-20}  {1,9}", "Your Fed tax is", fedTotal.ToString("C"));
            WriteLine("{0,-20}  {1,9}", "Your state tax is", stateTotal.ToString("C"));
            WriteLine("-------------------------------------");
            WriteLine("{0,-20}  {1,9}", "Your net pay is", netPay.ToString("C"));

            Console.WriteLine();
        }
    }
}
