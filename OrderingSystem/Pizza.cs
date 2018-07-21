using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Neudesic.OrderingSystem.Model
{
    public class Pizza
    {
        public void PizzaSelection()
        {
            int selection;
            Console.WriteLine("1:Veg 2:NonVeg");
            selection = Convert.ToInt32(Console.ReadLine());
            if (selection == 1)
            {
                var vegPizzaObject = new VegPizza();
                vegPizzaObject.VegPizzaSelection();
            }
            else
            {
                if (selection == 2)
                {
                    var nonVegPizzaObject = new NonVegPizza();
                    nonVegPizzaObject.NonVegPizzaSelection();
                }
                else
                {
                    throw new InvalidInputException();
                }
            }
        }
    }
    public class NonVegPizza : Pizza
    {
        public void NonVegPizzaSelection()
        {
            List<PizzaModel> pizzaList = new List<PizzaModel>();
            pizzaList.Add(new PizzaModel() { Id = 1, Name = "chicken cheese Burst", Price = 250 });
            pizzaList.Add(new PizzaModel() { Id = 2, Name = "chicken cheese Toast", Price = 270 });
            int choosedPizza;
            foreach (var pizza in pizzaList)
            {
                Console.WriteLine(pizza.Id + "." + pizza.Name + " " + pizza.Price);
            }
            choosedPizza = Convert.ToInt32(Console.ReadLine());
            foreach (var pizza in pizzaList)
            {
                if (pizza.Id == choosedPizza)
                {
                    Order.Cart.Add(new Order() { Id = pizza.Id, Name = pizza.Name, Price = pizza.Price });
                }
            }
        }
    }
    public class VegPizza : Pizza
    {
        public void VegPizzaSelection()
        {
            List<PizzaModel> pizzaList = new List<PizzaModel>();
            pizzaList.Add(new PizzaModel() { Id = 1, Name = "cheese Burst", Price = 250 });
            pizzaList.Add(new PizzaModel() { Id = 2, Name = "cheese Toast", Price = 270 });
            int choosedPizza;
            foreach (var pizza in pizzaList)
            {
                Console.WriteLine(pizza.Id + "." + pizza.Name + " " + pizza.Price);
            }
            choosedPizza = Convert.ToInt32(Console.ReadLine());
            foreach (var pizza in pizzaList)
            {
                if (pizza.Id == choosedPizza)
                {
                    Order.Cart.Add(new Order() { Id = pizza.Id, Name = pizza.Name, Price = pizza.Price });
                }
            }
        }
        
    }
}
