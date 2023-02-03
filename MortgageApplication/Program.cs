using System;
using static System.Console;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MortgageApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            char userinput = 'n';
            string applicantName;
            int creditScore;

            WriteLine("                       *** CSCC Merrydale Mortgage ***");
            Write("Would you like to check the credit score of a mortgage applicant [y/n] ?: ");

            while (!(userinput == 'N' || userinput == 'n'))
            {
                Write("\nPlease enter the applicant's name: ");
                applicantName = ReadLine();
                Write("Enter credit score: ");
                creditScore = Convert.ToInt32(ReadLine());
                try
                {
                    Applicant applicant = new Applicant(applicantName, creditScore);
                    WriteLine("{0} credit score return {1}", applicantName, applicant.Status);
                }
                catch (ArgumentException anyException)
                {
                    WriteLine(anyException.Message);
                }
                Write("\nDo want to contiune [y/n] ?: ");
                userinput = Convert.ToChar(ReadLine());
            }
            ReadLine();
        }
    }
    class Applicant
    {
        public Applicant(string name, int creditscore)
        {
            Name = name;
            CreditScore = creditscore;
            Status = ValidScore(creditscore);
        }
        public string Name 
        { get; set; }
        public double CreditScore
        { get; set; }
        public bool Status
        { get; set; }
        
        public bool ValidScore(int creditscore)
        {
            if (creditscore < 300 || creditscore > 850)
            {
                throw (new ArgumentException("\nInvalid score. Value does not fall within the expected range."));

            }
            else if (creditscore >= 650)
            {
                WriteLine("Applicant {0} credit score {1} is accepted, applicant is eligible for a mortgage.", Name, creditscore);
                return true;
            }
            else
            {
                WriteLine("Applicant {0} credit score {1} is rejected, applicant is not eligible for a mortgage", Name, creditscore);
                return false;
            }
        }
    }
}

