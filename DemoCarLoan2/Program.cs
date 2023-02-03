using System;
using static System.Console;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoCarLoan2
{
    class DemoCarLoan2
    {
        class Loan
        {
            public int LoanNumber { get; set; }
            public string LastName { get; set; }
            protected double loanAmount { get; set; }
            
            public const double MINIMUM_LOAN = 5000;

            class CarLoan : Loan
            {
               
                public string Make { get; set; }

                private int year;
               
                private const int EARLIEST_YEAR = 2006;
                private const int LOWEST_INVALID_NUM = 1000;

               static void Main()
               {
                   Loan aLoan = new Loan();
                   aLoan.LoanNumber = 2239;
                   aLoan.LastName = "Mitchell";
                   aLoan.loanAmount = 1000.00;
                   WriteLine("Loan #{0} for {1} is for {2}",
                       aLoan.LoanNumber, aLoan.LastName, aLoan.loanAmount.ToString("C2"));

                   CarLoan aCarLoan = new CarLoan();
                   aCarLoan.LoanNumber = 3358;
                   aCarLoan.LastName = "Jansen";
                   aCarLoan.LoanAmount = 20000.00;
                   aCarLoan.Make = "Ford";
                   aCarLoan.Year = 2005;
                   WriteLine("Loan #{0} for {1} is for {2}",
                       aCarLoan.LoanNumber, aCarLoan.LastName, aCarLoan.LoanAmount.ToString("C2"));
                   WriteLine("   Loan #{0} is for a {1} {2}",
                       aCarLoan.LoanNumber, aCarLoan.Year, aCarLoan.Make);
                   Read();
               }

               public double LoanAmount
               {
                   set
                   {
                       if (value < MINIMUM_LOAN)
                           loanAmount = MINIMUM_LOAN;
                       else
                           loanAmount = value;
                   }
                   get
                   {
                       return loanAmount;
                   }

               }
               public int Year
               {

                    set
                    {
                        if (value < EARLIEST_YEAR)
                        {
                            year = value;
                            loanAmount = 0;
                        }
                        else
                            year = value;
                    }
                    get
                    {
                        return year;
                    }
               }

               public new int LoanNumber
               {
                    get
                    {
                        return base.LoanNumber;
                    }
                    set
                    {
                        if (value < LOWEST_INVALID_NUM)
                            base.LoanNumber = value;
                        else
                            base.LoanNumber = value % LOWEST_INVALID_NUM;
                    }
               }
            }
        }
        
    }
}
