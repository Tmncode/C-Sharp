﻿//Written by <Tam Nguyen>
//Written on <11/4/2019>
using System;
using static System.Console;

namespace InteractiveAddition
{
    class Program
    {
        static void Main(string[] args)
        {
            string name, firstString, secondString;
            int first, second, sum;

            Write("Enter your name... ");
            name = ReadLine();
            Write("Hello {0}! Enter the first integer... ", name);

            firstString = ReadLine();
            first = Convert.ToInt32(firstString);

            Write("Enter the second integer... ");
            secondString = ReadLine();
            second = Convert.ToInt32(secondString);

            sum = first + second;

            WriteLine("{0}, the sum of {1} and {2} is {3}",
                name, first, second, sum);

        }
    }
}
