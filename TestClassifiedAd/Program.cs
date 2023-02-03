using System;
using static System.Console;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestClassifiedAd
{
    class Ads
    {
        static void Main(string[] args)
        {
            
            const double rate = 0.09;
            double total;
            ClassifiedAd Article = new ClassifiedAd();
            
            Article.Words = 599;
            total = Article.Words * rate;
           
            WriteLine("Your article have a total of {0} words, cost per word {1} your cost {2}",
                Article.Words, rate.ToString("C"), total.ToString("C"));
               
            Read();
        }
    }
    class ClassifiedAd
    {
        private int words;
        private double price;

        public int Words { get; set; }
        public double Price
        {
            get
            {
                return price;
            }
        }
    }
}
