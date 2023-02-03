using System;
using static System.Console;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PackageDemo
{
    class PackageDemo
    { 
        static void Main()
        {
            Package LightP = new Package();
            Package HeavyP = new Package();
            InsuredPackage inexpensiveP = new InsuredPackage();
            InsuredPackage ExpensiveP = new InsuredPackage();

            LightP.ID = "5588";
            LightP.Name = "Engineer,";
            LightP.Weight = 32;

            WriteLine("Name: " + LightP.Name + " Package ID: " + LightP.ID + " Ounces: " + LightP.Weight +
                " Charges: " + LightP.DeliveryPrice.ToString("C"));

            HeavyP.ID = "9855";
            HeavyP.Name = "Mike,";
            HeavyP.Weight = 34;

            WriteLine("Name: " + HeavyP.Name + " Package ID: " + HeavyP.ID + " Ounces: " + HeavyP.Weight +
                " Charges: " + HeavyP.DeliveryPrice.ToString("C"));

            inexpensiveP.ID = "7401";
            inexpensiveP.Name = "Danny,";
            inexpensiveP.Weight = 8;
            inexpensiveP.PkgValue = 15.00;

            WriteLine("Name: " + inexpensiveP.Name + " Package ID: " + inexpensiveP.ID + " Ounces: " + inexpensiveP.Weight +
                " Charges: " + inexpensiveP.DeliveryPrice.ToString("C"));

            ExpensiveP.ID = "7402";
            ExpensiveP.Name = "Jerry,";
            ExpensiveP.Weight = 13;
            ExpensiveP.PkgValue = 24.00;

            WriteLine("Name: " + ExpensiveP.Name + " Package ID: " + ExpensiveP.ID + " Ounces: " + ExpensiveP.Weight +
                " Charges: " + ExpensiveP.DeliveryPrice.ToString("C"));

            ReadLine();
        }
    }
    class Package
    {
        public string ID { get; set; }
        public string Name { get; set; }
        private int weight;
        protected double deliveryPrice;

        public const int WEIGHT = 32;
        public const double BASE = 5.00;
        public const double OUNCE_RATE = 0.12;

        public int Weight
        {
            get
            {
                return weight;
            }
            set
            {
                weight = value;
                if (Weight <= WEIGHT)
                    deliveryPrice = BASE;
                else
                    deliveryPrice = BASE + (Weight - WEIGHT) * OUNCE_RATE; 
            }
        }
        public double DeliveryPrice
        {
            get
            {
                return deliveryPrice;
            }
            set
            {
                deliveryPrice = value;
            }
        }

    }
    class InsuredPackage : Package
    {
        private double pkgValue;
        public const double InsuranceL = 1.00;
        public const double InsuranceH = 2.50;
        public const double LIMIT = 20.00;
        public double PkgValue
        {
            get
            {
                return pkgValue;
            }
            set
            {
                pkgValue = value;
                if (Weight <= WEIGHT)
                    base.deliveryPrice = BASE;
                else
                    base.deliveryPrice = BASE + (Weight - WEIGHT) * OUNCE_RATE;
                if (value < LIMIT)
                    base.deliveryPrice += InsuranceL;
                else
                    base.deliveryPrice += InsuranceH;
            }
        }
    }
}
