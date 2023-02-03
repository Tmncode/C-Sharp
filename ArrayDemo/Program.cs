using System;
using static System.Console;


namespace ArrayDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, input;
            int[] nums = { 0, 1, 2, 3, 4, 5, 6, 7, 8 };
            string inputString;

            WriteLine("1.To view the list in order from the first to last position. " +
                  "\n2.To view the list in order from the last to first. " +
                  "\n3.To choose a specfic position to view or 0 to quit. ");
            inputString = ReadLine();
            input = Convert.ToInt32(inputString);

            while (input != 0)
            {
                if (input == 1)
                {
                    WriteLine("Option 1: to view the list in order from first to last position: ");
                    for (x = 0; x < nums.Length; ++x)
                        Write("{0, 6}", nums[x]);
                }
                else if (input == 2)
                {

                    Array.Reverse(nums);
                    WriteLine("Option 2: to view th list in order from last to first position: ");
                    for (x = 0; x < nums.Length; ++x)
                        Write("{0, 6}", nums[x]);
                    Array.Reverse(nums);
                }
                else if (input == 3)
                {
                    Write("Option 3: Enter a specfic position to view: ");
                    x = Convert.ToInt32(ReadLine());
                    Write("The number at position {0} is {1}  ", x , nums[x - 1]);
                }
                WriteLine("\n1.To view the list in order from the first to last position." +
                    "\n2.To view the list in order from the last to first." +
                    "\n3.To choose a specfic position to view or 0 to quit. ");
                inputString = ReadLine();
                input = Convert.ToInt32(inputString);
            }
            
            ReadLine();
        }
    }
}
