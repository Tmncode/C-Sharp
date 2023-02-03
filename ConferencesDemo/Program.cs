using System;
using static System.Console;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConferencesDemo
{
    class ConferencesDemo
    {
        static void Main()
        {
            Conferences[] array1 = new Conferences[2];

            for (int x = 0; x < array1.Length; x++)
            {
                string group;
                string date;
                int num;

                WriteLine("Please enter in your group name.");
                group = ReadLine();

                WriteLine("Please enter in the date.");
                date = ReadLine();

                WriteLine("Please enter in your attendance number.");
                num = Convert.ToInt32(ReadLine());
                array1[x] = new Conferences(group, date, num);
            }

            Array.Sort(array1);

            for (int x = 0; x < array1.Length; x++)
            {
                WriteLine();
                WriteLine(" Name: " + array1[x].Name);
                WriteLine(" Date: " + array1[x].Date);
                WriteLine(" Attendee Number: " + array1[x].AttendeeNum);
                WriteLine();
                Read();
            }
            
        }
        class Conferences : IComparable
        {
            private string name;//{get; set;}
            private string date;//{get; set;}
            private int attendeeNum;//{get; set;}

            //Constructor
            public Conferences(string Name, string Date, int AttendeeNum)
            {
                name = Name;
                date = Date;
                attendeeNum = AttendeeNum;
            }

            // Proerties
            public string Name
            {
                get
                {
                    return name;
                }
                set
                {
                    name = value;
                }
            }

            public string Date
            {
                get
                {
                    return date;
                }
                set
                {
                    date = value;
                }
            }

            public int AttendeeNum
            {
                get
                {
                    return attendeeNum;
                }
                set
                {
                    attendeeNum = value;
                }
            }

            //IComparable
            int IComparable.CompareTo(object o)
            {
                int returnVal;
                Conferences temp = (Conferences)o;
                if (this.attendeeNum > temp.attendeeNum)
                {
                    returnVal = 1;
                }
                else if (this.attendeeNum < temp.attendeeNum)
                {
                    returnVal = -1;
                }
                else
                {
                    returnVal = 0;
                }
                return returnVal;
            }
        }
    }
}
