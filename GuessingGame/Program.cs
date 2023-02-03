using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessingGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Random ranNumberGenerator = new Random();
            int randomNumber;
            int userGuess;
            randomNumber = ranNumberGenerator.Next(1, 11);
            
            Console.WriteLine("I'm guessing of a number between 1 through 10! What is it?");
            userGuess = Convert.ToInt32(Console.ReadLine());

            if (randomNumber > userGuess)
            {
                Console.WriteLine("The random number ({0}) is greater then your guess ({1}), you guessed too low.", randomNumber, userGuess);
            }
            else if (randomNumber < userGuess)
            {
                Console.WriteLine("The random number ({0}) is less then your guess ({1}), you guessed too high.", randomNumber, userGuess);
            }
            else
            {
                Console.WriteLine("The random number ({0}) is equal to your guess ({1}), you guessed correctly!", randomNumber, userGuess);
            }
            Console.ReadLine();
        }
    }
}
