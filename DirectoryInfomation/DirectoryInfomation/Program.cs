using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Remoting.Services;

namespace DirectoryInfomation
{
    class Program
    {
        static void Main(string[] args)
        {
            const string END = "end";
            string dirName;
            
            Console.Write("Enter a folder, type end to quit >> ");
            dirName = Console.ReadLine();
            while (dirName.ToLower() != END)
            {
                bool exists = Directory.Exists(dirName);
                Console.WriteLine($"Directory exists? " + exists);
                if (exists)
                {
                    foreach (string s in Directory.GetFiles(dirName))
                    {
                        Console.WriteLine($"\t{s}");
                    }
                }
                else
                {
                    Console.WriteLine("Directory does not exists");
                }
                Console.Write("Enter a folder, type end to quit >> ");
                dirName = Console.ReadLine();      
            }
            
            Console.ReadLine();
        }
        
    }
}
