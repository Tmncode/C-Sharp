using System;
using static System.Console;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderDemo2
{
    public class OrderDemo
    {
        public static void Main()
        {
            //Create an array of five ShippedOrder objects. 
            Order[] aShippedOrder = new Order[5];


            /*Prompt the user for values for each Orders object; do NOT allow duplicate order numbers and force the user to reenter 
                the order when a duplicate order number is entered */

            //Input
            ToInput(aShippedOrder);

            //Output
            ToOutput(aShippedOrder);

            //Total
            double total = 0;
            total = Sum(aShippedOrder); 
            WriteLine(aShippedOrder.Length + " orders ' total is " + total);

            Read();
        }
        static void ToOutput(Order[] order)
        {
            for (int x = 0; x < order.Length; x++)
            {
                WriteLine("order number:" + order[x].OrderNumer + "   customer name:" + order[x].Customer + "   quantity:" + order[x].Quanity);
            }
        }
        static void ToInput(Order[] order)
        {
            bool wronginput = false;
            for (int x = 0; x < order.Length; x++)
            {
                order[x] = new Order();
                int OrderNumer;
                WriteLine("Please enter the order number for order {0}:  ", x + 1);
                while (!int.TryParse(ReadLine(), out OrderNumer))
                {
                    WriteLine("Please enter an integer");
                }

                wronginput = ToCompare(order, OrderNumer);
                while (wronginput)
                {
                    WriteLine("Please enter the order number for order {0}:  ", x + 1);
                    OrderNumer = Convert.ToInt32(ReadLine());
                    wronginput = ToCompare(order, OrderNumer);
                }
                order[x].OrderNumer = OrderNumer;

                WriteLine("Please enter the customer name for order {0}:  ", x + 1);
                order[x].Customer = ReadLine();

                WriteLine("Please enter the quantity for order {0}:  ", x + 1);
                order[x].Quanity = Convert.ToInt32(ReadLine());
            }
        }
        static bool ToCompare(Order[] order, int OrderNumer)
        {
            bool wronginput = false;
            if (order != null && OrderNumer > 0)
            {
                for (int y = 0; y < order.Length; y++)
                {
                    if (order[y] != null && order[y].OrderNumer == OrderNumer)
                    {
                        WriteLine("Sorry, this order number has already been entered, please try again");
                        wronginput = true;
                        
                    }
                }
            }
            return wronginput;
        }
        static double Sum(Order[] order)
        {
            double total = 0;
            for (int x = 0; x < order.Length; x++)
            {
                total += order[x].Total;
            }
            return total;
        }

        class Order
        {
            public int _quanity;
            public double _total;
            public const double ItemPrice = 19.95;
            public Order()
            {

            }
            public Order(int ordNum, string cusName, int numOrdered)
            {
                OrderNumer = ordNum;
                Customer = cusName;
                Quanity = numOrdered;
            }

            public int OrderNumer { get; set; }
            public string Customer { get; set; }
            public int Quanity
            {
                get
                {
                    return _quanity;
                }
                set
                {
                    _quanity = value;
                    _total = _quanity * ItemPrice;

                }
            }
            public double Total { get { return _total; } }
            public override string ToString()
            {
                return (GetType() +  "\n OrderNumber " + OrderNumer + " Customer " + Customer + " Quanity " + Quanity +
                    " @" + ItemPrice.ToString("C2") + Total.ToString("C2"));
            }

            public override bool Equals(Object e)
            {
                bool equal;
                Order temp = (Order)e;
                if (OrderNumer == temp.OrderNumer)
                    equal = true;
                else
                    equal = false;
                return equal;
            }
            public override int GetHashCode()
            {
                return OrderNumer;
            }
        }
    }
}
