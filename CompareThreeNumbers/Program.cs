using System;
using static System.Console;


namespace CompareThreeNumbers
{
    class Program
    {
        static void Main()
        {
            string numberString;
            int num1, num2, num3;

            Write("Enter an integer ");
            numberString = ReadLine();
            num1 = Convert.ToInt32(numberString);
            Write("Enter an integer ");
            numberString = ReadLine();
            num2 = Convert.ToInt32(numberString);
            Write("Enter an integer ");
            numberString = ReadLine();
            num3 = Convert.ToInt32(numberString);


            if (num1 == num2)
            {
                if (num1 == num3)
                    WriteLine("All three numbers are equal");
                else
                    WriteLine("First two equal");
            }
            else
            {

                if (num1 == num3)
                    WriteLine("Last two are equal");
                else
                    WriteLine("No two number are equal");
                ReadLine();
            }
                   
            

        }
    }
}
