using System;
using static System.Console;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderExceptionDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Order order = new Order(361, 4, 30);
            WriteLine("Item number 361 Quantity 4 Day order 30");
            
            try
            {
                order = new Order(1954, 9, 21);
            }
            catch (ArgumentException error)
            {
                WriteLine("Cannot place order w/ item number 1954 quantity 9 day order 21. gave: " + error.Message);            
            }
            ReadKey();
        }
        public class Order
        {
            public int itemNumber { get; set; }
            public int quantity { get; set; }
            public int dayOrder { get; set; }
            public Order(int ItemNumber, int Quantity, int DayOrder)
            {
                if(ItemNumber < 100 || ItemNumber > 999)
                {
                    throw new ArgumentException("Sorry item number out of range.");
                }
                else if(Quantity < 1 || Quantity > 12)
                {
                    throw new ArgumentException("Sorry quantity out of range.");
                }
                else if(DayOrder < 1 || DayOrder > 31)
                {
                    throw new ArgumentException("Sorry day order out of range.");
                }
                itemNumber = ItemNumber;
                quantity = Quantity;
                dayOrder = DayOrder;
            }
        }
    }
}
