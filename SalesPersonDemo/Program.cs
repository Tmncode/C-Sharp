using System;
using static System.Console;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesPersonDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            RealEstateSalesperson res = new RealEstateSalesperson("phil", "Max", 0.99f);
            GirlScout gs = new GirlScout("Tia", "Amy");

            WriteLine(res);
            WriteLine(gs);

            res.MakeSale(2000000);
            gs.MakeSale(15);
            WriteLine();

            WriteLine(res);
            WriteLine(gs);

            res.MakeSale(521583);
            gs.MakeSale(5);
            WriteLine();

            WriteLine(res);
            WriteLine(gs);

            Read();
        }
    }
    abstract class Salesperson
    {
        private string _firstName;
        private string _lastName;

        public Salesperson(string first, string last)
        {
            this.FirstName = first;
            this.LastName = last;
        }
        public string FirstName
        {
            get
            {
                return this._firstName;
            }
            set
            {
                this._firstName = value;
            }
        }
        public string LastName
        {
            get
            {
                return this._lastName;
            }
            set
            {
                this._lastName = value;
            }
        }
        public string GetFullName()
        {
            return this.FirstName + " " + this.LastName;
        }
        public override string ToString()
        {
            return string.Format("{0}\n------------------------------\nFull Name: {1}\n",
                this.GetType().ToString().Substring(this.GetType().ToString().IndexOf(".") + 1), this.GetFullName());
        }
    }
    class RealEstateSalesperson : Salesperson, ISellable
    {
        private float _totalValueSold;
        private float _totalCommisionEarned;
        private float _commisionRate;

        public RealEstateSalesperson(string first, string last, float commisionRate) : base(first, last)
        {
            this._totalValueSold = 0;
            this._totalCommisionEarned = 0;
            this._commisionRate = commisionRate;
        }
        public float TotalValueSold
        {
            get
            {
                return this._totalValueSold;
            }
            set
            {
                this._totalValueSold = value;
                this.TotalCommisionEarned = this.TotalValueSold * this.CommisionRate;
            }
        }
        public float TotalCommisionEarned
        {
            get
            {
                return this._totalCommisionEarned;
            }
            set
            {
                this._totalCommisionEarned = value;
            }
        }
        public float CommisionRate
        {
            get
            {
                return this._commisionRate;
            }
            set
            {
                this._commisionRate = value;
            }
        }
        public void MakeSale(int dollarValueForAHouse)
        {
            this.SalesSpeech();
            this.TotalValueSold = dollarValueForAHouse;
        }
        public void SalesSpeech()
        {
            WriteLine("I," + this.GetFullName() + ", just sold a real estate property!");
        }
        public override string ToString()
        {
            return base.ToString() + string.Format("Total Value Sold: {0:C}\nTotal Commision Earned: {1:C}\nCommision Rate: {2:p}\n",
                this.TotalValueSold, this.TotalCommisionEarned, this.CommisionRate);
        }

    }
    class GirlScout : Salesperson, ISellable
    {
        private int _boxesCookiesSold;

        public GirlScout(string first, string last) : base(first, last)
        {
            this.BoxesCookiesSold = 0;
        }

        public int BoxesCookiesSold
        {
            get
            {
                return this._boxesCookiesSold;
            }
            set
            {
                this._boxesCookiesSold = value;
            }
        }

        public void MakeSale(int numBoxes)
        {
            this.SalesSpeech();
            this.BoxesCookiesSold += numBoxes;
        }

        public void SalesSpeech()
        {
            WriteLine("I, " + this.GetFullName() + ", just sold some cookies!");
        }

        public override string ToString()
        {
            return base.ToString() + string.Format("Boxes of Cookes Sold: {0}\n", this.BoxesCookiesSold);
        }

    }
    interface ISellable
    {
        void SalesSpeech();
        void MakeSale(int number);
    }

}
