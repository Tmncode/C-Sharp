using System;
using static System.Console;


namespace DisplayMultiplicationTable
{
    class Program
    {
        static void Main(string[] args)
        {
            int j, i;
            int n = 10;
            // Indent column headers
            Write("{0, 4}", null);                     
            // Write column headers
            for (j = 1; j <= n; j++)
                Write("{0, 4}", j);

            // Write column header seperator
            WriteLine();
            WriteLine("_____________________________________________________");

            // Write the table
            for (j=1; j<=n; j++)
            {
                // Write the row header
                Write("{0, 4}", j);

                for (i = 1; i <= n; i++)
                {
                    // Write the row values
                    Write("{0, 4}", j * i);
                }
                // Finish the line
                WriteLine();

            }
            ReadLine();
        }
    }
}
