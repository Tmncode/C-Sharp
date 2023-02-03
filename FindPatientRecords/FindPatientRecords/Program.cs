using System;
using System.IO;
using System.Text.RegularExpressions;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindPatientRecords
{
    class Program
    {
        static void Main(string[] args)
        {
            FileStream file = new FileStream(@"D:\C#\CSharp.Chapter.14\CustomersInfo.txt",
                FileMode.Open, FileAccess.Read);
            StreamReader reader = new StreamReader(file);

            Console.Write("Enter ID: ");
            string id = Console.ReadLine(), patientInfo = reader.ReadLine();

            while (!string.IsNullOrEmpty(patientInfo))
            {
                if (Regex.IsMatch(patientInfo, id))
                {
                    Console.WriteLine($"Found customer {patientInfo}");
                    break;
                }
                else
                {
                    Console.WriteLine($"Customer does not exist");
                }
                patientInfo = reader.ReadLine();
            }
            file.Close();
            reader.Close();
            Console.ReadLine();
        }
    }
}
