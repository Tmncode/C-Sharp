using System;
using static System.Console;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoCarLoan
{
    class Loan
    {
        public int LoanNumber { get; set; }
        public string LastName { get; set; }
        public double LoansAmount { get; set; }
    }
    class CarLoan : Loan
    {
        public int Year { get; set; }
        public string Make { get; set; }
    }
    class DemoCarLoan
    {
        static void Main()
        {
            Loan aLoan = new Loan();
            aLoan.LoanNumber = 2239;
            aLoan.LastName = "Mitchell";
            aLoan.LoansAmount = 1000.00;
            WriteLine("Loan #{0} for {1} is for {2}",
                aLoan.LoanNumber, aLoan.LastName, aLoan.LoansAmount.ToString("C2"));

            CarLoan aCarLoan = new CarLoan();
            aCarLoan.LoanNumber = 3358;
            aCarLoan.LastName = "Jansen";
            aCarLoan.LoansAmount = 2000.00;
            aCarLoan.Make = "Ford";
            aCarLoan.Year = 2005;
            WriteLine("Loan #{0} for {1} is for {2}",
                aCarLoan.LoanNumber, aCarLoan.LastName, aCarLoan.LoansAmount.ToString("C2"));
            WriteLine("   Loan #{0} is for a {1} {2}",
                aCarLoan.LoanNumber, aCarLoan.Year, aCarLoan.Make);

            Read();
        }
    }
}
