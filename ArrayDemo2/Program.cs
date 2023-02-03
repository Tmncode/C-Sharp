using System;
using static System.Console;


namespace ArrayDemo2
{
    class ArrayDemo2
    {
        static void Main(string[] args)
        {
            int[] scores = new int[8];
            int x;
            string inputString;

            for(x = 0; x < scores.Length; ++x)
            {
                Write("Enter your score on the test {0} ", x + 1);
                inputString = ReadLine();
                scores[x] = Convert.ToInt32(inputString);
            }

            // Add statement that create a dashed line to Visually separate the input from
            // output.Display "Scores in original order:", then use a loop to display each 
            //  score in a field that is six characters wide.
            WriteLine("\n----------------------------");
            WriteLine("Scores in original order:");
            for (x = 0; x < scores.Length; ++x)
                Write("{0, 6}", scores[x]);

            // Add another dashed line, visual separation, then pass the scores array to
            // the Array.Sort() method. Display Scores in sorted order:, then use a loop
            // to display each of the newly sorted scores.
            WriteLine("\n----------------------------");
            Array.Sort(scores);
            WriteLine("Scores in sorted order:");
            for (x = 0; x < scores.Length; ++x)
                Write("{0, 6}", scores[x]);

            // Add one more dashed line, reverse the array elements by passisng scores to
            // the Array.Reverse() method, display Scores in reverse order:, and show
            // the rearranged scores.
            WriteLine("\n----------------------------");
            Array.Reverse(scores);
            WriteLine("Scores in reverse order:");
            for (x = 0; x < scores.Length; ++x)
                Write("{0, 6}", scores[x]);
            WriteLine("\nDone!! ");
            ReadLine();
        }
    }
}
