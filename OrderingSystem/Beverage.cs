using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Neudesic.OrderingSystem.Model
{
    public class Beverage
    {
        public void BeverageSelection()
        {
            List<BeverageModel> beverageList = new List<BeverageModel>();
            beverageList.Add(new BeverageModel() { Id = 1, Name = "Coke", Price = 50 });
            beverageList.Add(new BeverageModel() { Id = 2, Name = "Pepsi", Price = 30 });
            int choosedBeverage;
            foreach (var beverage in beverageList)
            {
                Console.WriteLine(beverage.Id + "." + beverage.Name + " " + beverage.Price);
            }
            choosedBeverage = Convert.ToInt32(Console.ReadLine());
            foreach (var beverage in beverageList)
            {
                if (beverage.Id == choosedBeverage)
                {
                    Order.Cart.Add(new Order() { Id = beverage.Id, Name = beverage.Name, Price = beverage.Price });
                }
            }
        }
    }
    
}
