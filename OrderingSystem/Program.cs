using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Neudesic.OrderingSystem.Model
{
    public class Program
    {
        public double total;
        static void Main(string[] args)
        {
            var ordersystemobject= new OrderSystem();
            var pizza = new Pizza();
            var beverage = new Beverage();
            var sides = new Sides();
            ordersystemobject.PizzaOrderProcessed += pizza.PizzaSelection;
            ordersystemobject.BeverageOrderProcessed += beverage.BeverageSelection;
            ordersystemobject.SidesOrderProcessed += sides.SidesSelection;
            ordersystemobject.OrderProcess();
        }
    }
    [Serializable]
    class InvalidInputException : Exception
    {
        public InvalidInputException()
        {
            Console.WriteLine("Invalid Input");
        }
    }
}
