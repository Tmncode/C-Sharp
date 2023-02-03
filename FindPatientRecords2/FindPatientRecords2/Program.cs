using System;
using System.Text.RegularExpressions;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindPatientRecords2
{
    class Program
    {
        static void Main(string[] args)
        {
            FileStream file = new FileStream(@"D:\C#\CSharp.Chapter.14\CustomersInfo.txt", FileMode.Open, FileAccess.Read);
            StreamReader reader = new StreamReader(file);

            Console.Write("Enter balance owed: ");
            string id = Console.ReadLine(), patientInfo = reader.ReadLine();

            while (!string.IsNullOrEmpty(patientInfo))
            {
                if (Regex.IsMatch(patientInfo, id))
                {
                    Console.WriteLine($"Customer exists:  {patientInfo}");
                }
                else
                {
                    Console.WriteLine("Customer does not exists with the amount owed");
                }
                patientInfo = reader.ReadLine();
            }
            file.Close();
            reader.Close();
            Console.ReadLine();
        }
    }
}
