using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Neudesic.OrderingSystem.Model
{
    class OrderSystem
    {
        public delegate void OrderProcessedEventHandler();
        public event OrderProcessedEventHandler PizzaOrderProcessed;
        public event OrderProcessedEventHandler BeverageOrderProcessed;
        public event OrderProcessedEventHandler SidesOrderProcessed;
        Bill bill = new Bill();
        public void OrderProcess()
        {
            int input1;
            string input;
            do
            {
                Console.WriteLine("1:Pizza 2:Beverages 3:Sides");
                input1 = Convert.ToInt32(Console.ReadLine());
                switch (input1)
                {
                    case 1:
                        OnProcessedPizza();
                        break;
                    case 2:
                        OnProcessedBeverage();
                        break;
                    case 3:
                        OnProcessedSides();
                        break;
                    default:
                        throw new InvalidInputException();
                        break;
                }
                Console.WriteLine("do you add anything type yes");
                input = Console.ReadLine();
            } while (input == "yes");
            bill.Payment();
        }
        protected virtual void OnProcessedPizza()
        {
            PizzaOrderProcessed?.Invoke(); // if any subscriber call the method in that
        }
        protected virtual void OnProcessedBeverage()
        {
            BeverageOrderProcessed?.Invoke(); // if any subscriber call the method in that
        }
        protected virtual void OnProcessedSides()
        {
            SidesOrderProcessed?.Invoke(); // if any subscriber call the method in that
        }
    }
}
