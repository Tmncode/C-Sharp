using System;
using static System.Console;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reverse4
{
    class Program
    {
        static void Main(string[] args)
        {
            Array myArray = Array.CreateInstance(typeof(String), 5);
            myArray.SetValue("My", 0);
            myArray.SetValue("Son", 1);
            myArray.SetValue("Love", 2);
            myArray.SetValue("Dinosaurs", 3);
            myArray.SetValue("The end!", 4);

            // Displays the values of the Array.
            WriteLine("The Array initially contains the following values:");
            PrintIndexAndValues(myArray);

            // Reverses the sort of the values of the Array.
            Array.Reverse(myArray);

            // Displays the values of the Array.
            WriteLine("After reversing:");
            PrintIndexAndValues(myArray);
            Read();
        }

        public static void PrintIndexAndValues(Array myArray)
        {
            for (int i = myArray.GetLowerBound(0); i <= myArray.GetUpperBound(0); i++)
                WriteLine("[{0}] : {1}", i, myArray.GetValue(i));
        }
    }
}
