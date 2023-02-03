using System;
using static System.Console;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desks2
{
    class Program
    {
        static void Main(string[] args)
        {

            int numberOfDrawers = 0;
            string deskWoodType = "o";
            double cost = 0;
            drawersMeth(out numberOfDrawers);
            woodTypeMeth(out deskWoodType);
            CalculateCostMeth(ref deskWoodType, ref numberOfDrawers, out cost);
            OutPutCostMeth(numberOfDrawers, deskWoodType, cost);

        }

        private static void drawersMeth(out int numberOfDrawers)
        {
            int numOfDrawers;
            WriteLine("Enter the number of desk drawers");
            numOfDrawers = Convert.ToInt16(ReadLine());
            numberOfDrawers = numOfDrawers;
        }

        private static string woodTypeMeth(out string deskWoodType)
        {
            WriteLine("Enter the desk wood type. (ex. type mahogany, oak, or pine)");
            deskWoodType = Convert.ToString(ReadLine());
            Write("The wood finish you have selected is: ", deskWoodType);
            switch (deskWoodType)
                {
                    case "mahogany":
                        {
                            WriteLine("mahogany", deskWoodType);
                        break;
                        }
                    case "oak":
                        {
                            WriteLine("oak", deskWoodType);
                        break;
                        }
                    case "pine":
                        {
                            WriteLine("pine", deskWoodType);
                        break;
                        }
                    default:
                        {
                            WriteLine("invalid input", deskWoodType);
                        break;
                        }
                }
                return deskWoodType;
        }

        private static double CalculateCostMeth(ref string deskWoodType, ref int numberOfDrawers, out double cost)
        {
            int pine = 100;
            int oak = 140;
            int other = 180;
            int surcharge = 30;
            if (deskWoodType == "p")
                cost = pine + (numberOfDrawers * surcharge);
            else if (deskWoodType == "o")
                cost = oak + (numberOfDrawers * surcharge);
            else
                cost = other + (numberOfDrawers * surcharge);
            return cost;
        }

        private static void OutPutCostMeth(int numberOfDrawers, string deskWoodType, double cost)
        {
            double totalCost = cost;
            WriteLine("The number of drawers is {0}", numberOfDrawers);
            
            WriteLine("The total cost is {0:c2}", totalCost);
            Read();
        }
    }
}
