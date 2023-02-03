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
        static void Main(string[] args)
        {
            Package LightP = new Package();
            Package HeavyP = new Package();
            InsuredPackage inexpensiveP = new InsuredPackage();
            InsuredPackage expensiveP = new InsuredPackage();

            LightP.Name = " Engineer, ";
            LightP.Id = "1234";
            LightP.Weight = 25;

            WriteLine("Name:" + LightP.Name + "Package ID: " + LightP.Id + " Ounces: " + LightP.Weight + " Delivery Charges: " + LightP.DeliveryCharges.ToString("C"));

            HeavyP.Name = " Mr T, ";
            HeavyP.Id = "5678";
            HeavyP.Weight = 49;

            WriteLine("Name:" + HeavyP.Name + "Package ID: " + HeavyP.Id + " Ounces: " + HeavyP.Weight + " Delivery Charges: " + HeavyP.DeliveryCharges.ToString("C"));


            inexpensiveP.Name = " Rock, ";
            inexpensiveP.Id = "1598";
            inexpensiveP.Weight = 10;
            inexpensiveP.PkgValue = 19.99;

            WriteLine("Name:" + inexpensiveP.Name + "Package ID: " + inexpensiveP.Id + " Ounces: " + inexpensiveP.Weight + " Delivery Charges: "
                + inexpensiveP.DeliveryCharges.ToString("C"));

            expensiveP.Name = " Sandra, ";
            expensiveP.Id = "1597";
            expensiveP.Weight = 13;
            expensiveP.PkgValue = 25;

            WriteLine("Name:" + expensiveP.Name + "Package ID: " + expensiveP.Id + " Ounces: " + expensiveP.Weight + " Delivery Charges: "
                + expensiveP.DeliveryCharges.ToString("C"));

            Read();

        }
    }

    class Package
    {
        public string Id { get; set; }
        public string Name { get; set; }
        private int weight;
        protected double deliveryCharges;
        
        public const int WEIGHT = 32;
        public const double BASE = 5.00;
        public const double OUNCE_RATE = 0.12;

        //Method for delivery charges
        public double DeliveryCharges
        {
            get
            {
                return deliveryCharges;
            }
            set
            {
                deliveryCharges = value;
            }
        }

        public int Weight
        {
            get
            {
                return weight;
            }
            set
            {
                weight = value;
                if (weight <= WEIGHT)
                    deliveryCharges = BASE;
                else
                    deliveryCharges = BASE + (Weight - WEIGHT) * OUNCE_RATE;
            }
        }

    }
    class InsuredPackage : Package
    {
        private double pkgValue;
        public const double LOWPRICE = 1.00;
        public const double HIGHPRICE = 2.50;
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
                    base.deliveryCharges = BASE;
                else
                    base.deliveryCharges = BASE + (Weight - WEIGHT) * OUNCE_RATE;
                if (value < LIMIT)
                    base.deliveryCharges += LOWPRICE;
                else
                    base.deliveryCharges += HIGHPRICE;
            }
        }
         
    }
}
