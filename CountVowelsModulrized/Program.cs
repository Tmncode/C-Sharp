using System;
using static System.Console;
using System.Linq;


namespace CountVowelsModulrized
{
    class Program
    {
       static void Main()
       {
            int total = 0;
            char[] vowels = { 'a', 'e', 'i', 'o', 'u' };

            Write("I got my car wash yesterday after school.\n");

            string sentence = ReadLine().ToLower();
            sentence = "I got my car wash yesterday after school.";

            total = sentence.Count(x => vowels.Contains(x));

            WriteLine("Your total number of vowels in the sentence is: {0}", total);

            ReadLine();
       }
    }
}
