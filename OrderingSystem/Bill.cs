using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Neudesic.OrderingSystem.Model
{
    public class Bill
    {
        public double total = 0;
        public void Payment()
        {
            foreach (var item in Order.Cart)
            {
                total = total + item.Price;
            }
            Console.WriteLine("Your bill is" + total);
        }
    }
}
