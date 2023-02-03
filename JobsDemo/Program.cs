using System;
using static System.Console;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobsDemo
{
    class JobDemo
    {


        static void Main()
        {
            Job job1 = new Job();
            Job job2 = new Job();
            Job job3 = new Job();

            job1.Description = "wash windows";
            job1.Time = 3.5;
            job1.Hourly = 25.00;
            job2.Description = "rake leaves";
            job2.Time = 2;
            job2.Hourly = 18.50;
            job3 = job1 + job2;

            Display(job1);
            Display(job2);
            Display(job3);
            Read();
        }

        static void Display(Job jobs)
        {
            WriteLine("Job : {0} is {1} per hour for {2} hours.\n    Total = {3}",
               jobs.Description, jobs.Hourly.ToString("C"), jobs.Time, jobs.Total.ToString("C"));
        }


    }
    class Job
    {
        private string description;
        private double time;
        private double hourly;
        private double total;

        public string Description
        {
            get
            {
                return description;
            }
            set
            {
                description = value;
            }
        }

        public double Time
        {
            get
            {
                return time;
            }
            set
            {
                time = value;
                CalcTotal();
            }
        }

        public double Hourly
        {
            get
            {
                return hourly;
            }
            set
            {
                hourly = value;
                CalcTotal();
            }
        }

        public double Total
        {
            get
            {
                return total;
            }
        }

        private void CalcTotal()
        {
            total = Time * Hourly;
        }

        public static Job operator +(Job j1, Job j2)
        {
            Job temp = new Job();
            temp.Description = j1.Description + " and " + j2.Description;
            temp.Time = j1.Time + j2.Time;
            temp.Hourly = (j1.Hourly + j2.Hourly) / 2;
            return temp;
        }
    }
}


