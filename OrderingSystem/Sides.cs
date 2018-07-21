using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Neudesic.OrderingSystem.Model
{
    public class Sides
    {
        public void SidesSelection()
        {
            List<SidesModel> sideList = new List<SidesModel>();
            sideList.Add(new SidesModel() { Id = 1, Name = "French fries", Price = 150 });
            sideList.Add(new SidesModel() { Id = 2, Name = "Wrap", Price = 130 });
            int choosedSides;
            foreach (var side in sideList)
            {
                Console.WriteLine(side.Id + "." + side.Name + " " + side.Price);
            }
            choosedSides = Convert.ToInt32(Console.ReadLine());
            foreach (var side in sideList)
            {
                if (side.Id == choosedSides)
                {
                    Order.Cart.Add(new Order() { Id = side.Id, Name = side.Name, Price = side.Price });
                }
            }
        }
    }
}
