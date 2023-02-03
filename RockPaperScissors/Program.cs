using System;
using static System.Console;

namespace RockPaperScissors
{
    class Program
    {

        static void Main(string[] args)
        {
            string  inputPlayer, inputCPU;
            int randomInt;
           
            Write("Choose between ROCK, PAPER, or  SCISSOR: \t\t");                     
            inputPlayer = ReadLine();
            inputPlayer.ToUpper();

            Random rnd = new Random();

            randomInt = rnd.Next(1, 4);
            
            
            switch (randomInt)
            {
                case 1:
                    inputCPU = "Rock";
                    WriteLine("CPU choose ROCK  ");
                    if (inputPlayer == "rock")
                    {
                        WriteLine("It's a Draw!!  ");
                    }
                    else if (inputPlayer == "paper")
                    {
                        WriteLine("You Win!! Paper beats rock, because a piece of paper can cover a rock\n\n");
                       
                    }
                    else if (inputPlayer == "scissor") 
                    {
                        WriteLine("You Lose!!  Rock beats scissor, because a rock can break a pair of scissors\n\n");
                       
                    }
                    break;
                case 2: 
                    inputCPU = "Paper";
                    WriteLine("CPU choose PAPER  ");
                    if (inputPlayer == "rock")
                    {
                        WriteLine("It's a Draw!!  ");
                    }
                    else if (inputPlayer == "paper") 
                    {
                        WriteLine("You Win!! Paper beats rock, because a piece of paper can cover a rock\n\n");
                       
                    }
                    else if (inputPlayer == "scissor") 
                    {
                        WriteLine("You Lose!!  Rock beats scissor, because a rock can break a pair of scissors\n\n");
                        
                    }
                    break;
                case 3: 
                    inputCPU = "Scissor";
                    WriteLine("CPU choose SCISSOR  ");
                    if (inputPlayer == "rock")
                    {
                        WriteLine("It's a Draw!!  ");
                    }
                    else if (inputPlayer == "paper")
                    {
                        WriteLine("You lose!! Paper beats rock, because a piece of paper can cover a rock\n\n");
                        
                    }
                    else if (inputPlayer == "scissor")
                    {
                        WriteLine("You Win!!  Rock beats scissor, because a rock can break a pair of scissors\n\n");
                        
                    }
                    break;
                case 4:
                    inputCPU = "Invalid input  ";
                    break;
            }
            ReadLine();

        }
    }
}
