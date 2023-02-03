using System;
using static System.Console;


namespace SalesLetter
{
    class Program
    {
        static void Main(string[] args)
        {
            
            WriteLine("Hyper Car Wash");
            WriteLine("Grand Openning starting Monday end on Sunday");
            WriteLine("We offer full service from exterior to interior");
            WriteLine("All car wash or free from Monday thru Sunday come visit our car wash today!!\n");
            DisplayContactInfo();
            
            WriteLine("We offer complete detailing for half price during our 1 week grand openning");
            WriteLine("Come take advantage of our special offer this week.\n");
            DisplayContactInfo();

            WriteLine("Thank you for your business!!!\n");
            DisplayContactInfo();

        }
        private static void DisplayContactInfo()
        {
            WriteLine("Tam Nguyen");
            WriteLine("Contact Infomation");
            WriteLine("Email address: www.blank@yahoo.com");
            WriteLine("Phone number: 405-524-1000");
            WriteLine("Cell phone number: 405-815-1234");
            ReadLine();
        }

    }
}
