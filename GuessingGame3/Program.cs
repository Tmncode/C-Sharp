using System;
using static System.Console;

namespace GuessingGame3
{
    class Program
    {
        static void Main(string[] args)
        {
            Random ranNumberGenerator = new Random();
            int randomNumber, userGuess, lowguess, highguess;
            int min = 1;
            int max = 10;
            int guesscount = 1;
            int preguess = 0;

            randomNumber = ranNumberGenerator.Next(min, max + 1);
            Console.WriteLine("I'm guessing of a number between 1 through 10! What is it?");

            userGuess = Convert.ToInt32(Console.ReadLine());
            while (userGuess != randomNumber)
            {
                while (userGuess < min || userGuess > max)
                {
                    WriteLine("Invalid guess! The guess must be beteen {0} and {1} inclusive!", min, max);
                    Write("Guess again: ");
                    userGuess = Convert.ToInt32(ReadLine());
                }
                if (userGuess < randomNumber)
                {
                    if (guesscount > 1 && userGuess >= preguess && preguess < randomNumber)
                    {
                        Console.WriteLine("DUMB ANSWER!, You should of known not to make such a low guess");
                    }
                    else
                    {
                        lowguess = guesscount;
                        Console.WriteLine("The random number ({0}) is greater then your guess ({1}), you guessed too low.", randomNumber, userGuess);
                    }
                }
                else if (userGuess > randomNumber)
                {
                    if (guesscount > 1 && guesscount >= preguess && preguess > randomNumber)
                    {
                        Console.WriteLine("DUMB ANSWER!, You should of known not to make such a high guess");
                    }
                    else
                    { 
                        highguess = guesscount;
                        Console.WriteLine("The random number ({0}) is less then your guess ({1}), you guessed too high.", randomNumber, userGuess);
                    }
                }
                preguess = guesscount;
                ++guesscount;
                Console.Write("Guess again: ");
                userGuess = Convert.ToInt32(ReadLine());
            }
            Console.WriteLine("Your guess is correct!\nYou have Guessed {0} valid times.", guesscount);
            Console.ReadLine();
            
        }
    }
}
