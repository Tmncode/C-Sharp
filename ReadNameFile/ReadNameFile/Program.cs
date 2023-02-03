using System;
using static System.Console;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReadNameFile
{
    class Program
    {
        static void Main(string[] args)
        {
            FileStream file = new FileStream("Names.txt",
                FileMode.Open, FileAccess.Read);
            StreamReader reader = new StreamReader(file);

            int count = 1;
            string name;
            WriteLine("Display all names");
            name = reader.ReadLine();
            while(name != null)
            {
                WriteLine("" + count + " " + name);
                name = reader.ReadLine();
                ++count;

            }
            reader.Close();
            file.Close();
            Console.ReadLine();
        }
    }
}
