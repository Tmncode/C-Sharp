//Written by <Tam M. Nguyen>
//Written on <11/1/19>
using static System.Console;

namespace CompareNames1
{
    class Program
    {
        static void Main()
        {
            string name1 = "Amy";
            string name2 = "Amy";
            string name3 = "Mathew";

            WriteLine("compare {0} to {1}: {2}",
                name1, name2, name1 == name2);
            WriteLine("compare {0} to {1}: {2}",
                name1, name3, name1 == name3);
        }
    }
}
