using System;
using static System.Console;


namespace AdmissionModularized
{
    class Program
    {
        static void Main(string[] args)
        {
            string userInPut1, userInPut2;
            Applicant student = new Applicant();

            WriteLine("Please enter your grade point average");
            userInPut1 = ReadLine();
            student.gpa = Convert.ToDouble(userInPut1);

            WriteLine("Please enter your admission test score");
            userInPut2 = ReadLine();
            student.score = Convert.ToDouble(userInPut2);

            if (student.IsAdmitted())
                WriteLine("You are accepted, congratulations!");
            else
                WriteLine("Sorry, but you do not meet requirements ");
            ReadLine();
        }
    }

    class Applicant
    {
        const double minGPA = 3.0;
        const double minScore = 60;
        const double highScore = 80;
        public double gpa, score;
        
        public bool IsAdmitted()
        {
            if (score > highScore)
                return true;
            if (gpa >= minGPA && score > minScore)
                return true;
            return false;
        }
    }
}
