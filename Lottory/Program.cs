using System;
using  static System.Console;
using System.Text;
using System.Threading.Tasks;

namespace Lottory
{
    class Program
    {
        static void Main(string[] args)
        {
            int min = 1;
            int max = 4;

            int winnings;

            const int WINNINGS1 = 10000;
            const int WINNINGS2 = 1000;
            const int WINNINGS3 = 100;
            const int WINNINGS4 = 10;

            Random ranNumberGenerator = new Random();

            int ran1 = ranNumberGenerator.Next(min, max + 1);
            int ran2 = ranNumberGenerator.Next(min, max + 1);
            int ran3 = ranNumberGenerator.Next(min, max + 1);

            int number1;
            int number2;
            int number3;
            int matches = 0;

            Write("Enter a digit from {0} to {1} >> ", min, max);
            number1 = Convert.ToInt32(ReadLine());
            Write("Enter a second digit from {0} to {1} >> ", min, max);
            number2 = Convert.ToInt32(ReadLine());
            Write("And finally a thrid digit from {0} to {1} >> ", min, max);
            number3 = Convert.ToInt32(ReadLine());
            WriteLine("The winning combination was {0}{1}{2}", ran1, ran2, ran3);

            if (number1 == ran1 && number2 == ran2 && number3 == ran3)
            {
                matches = 4;
            }
            else
            {
                if (number1 == ran1)
                {
                    ++matches;
                    ran1 = 99;
                }
                else 
                    if(number1 == ran2)
                    {
                        ++matches;
                        ran2 = 99;
                    }  
                else 
                    if(number1 == ran3)
                    {
                        ++matches;
                        ran3 = 99;
                    }
                if(number2 == ran1)
                {
                    ++matches;
                    ran1 = 99;
                }
                else 
                    if(number2 == ran2)
                    {
                        ++matches;
                        ran2 = 99;
                    }
                else 
                    if(number2 == ran3)
                    {
                        ++matches;
                        ran3 = 99;
                    }
                if(number3 == ran1)
                {
                    ++matches;
                    ran1 = 99;
                }
                else 
                    if(number3 == ran2)
                    {
                        ++matches;
                        ran2 = 99;
                    }
                else 
                    if(number3 == ran3)
                    {
                        ++matches;
                        ran3 = 99;
                    }
            }
            if (matches == 4)
                winnings = WINNINGS1;
            else 
                if (matches == 3)
                winnings = WINNINGS2;
            else 
                if (matches == 2)
                winnings = WINNINGS3;
            else 
                if (matches == 1)
                winnings = WINNINGS4;
            else
                winnings = 0;
            WriteLine("You won ${0}", winnings);
            ReadLine();
        }
    }
}
