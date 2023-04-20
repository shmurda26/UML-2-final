using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UML_2
{
    public class MenuCatalog
    {
        List<Pizza> _pizzas;

        public MenuCatalog()
        {
            _pizzas = new List<Pizza>();
        }

        public void Create(Pizza p)
        {
            _pizzas.Add(p);
        }

        public void PrintMenu()
        {
            Console.WriteLine(" Menu:");
            Console.WriteLine("****************************");
            foreach (var p in _pizzas)
            {
                Console.WriteLine($"{p}");
            }

        }

        public Pizza Read(int number)
        {
            //foreach (var p in _pizzas)
            //{
            //    if (p.Number==n)
            //    {
            //        return p;
            //    }

            //}
            return _pizzas[number - 1];

        }
        public Pizza? SearchPizza(string name)
        {
            foreach (var p in _pizzas)
            {
                if (p.Name == name)
                {
                    return p;
                }

            }
            return null;

        }
        public void Update(Pizza p, int price)
        {
            //foreach (var p in _pizzas)
            //{
            //    if (p.Number == pizza.Number)
            //    {
            //        p.Name= pizza.Name;
            //        p.Price= pizza.Price;
            //        return;
            //    }

            //} 

            p.Price = price;


        }
        public void Delete(Pizza pizza)
        {
            foreach (var p in _pizzas)
            {
                if (p.Number == pizza.Number)
                {
                    pizza = p;
                    break;

                }
            }
            _pizzas.Remove(pizza);
        }

        //public void Delete(int pizzaNo)
        //{

        //    Pizza foundPizza = null;

        //    foreach (var p in _pizzas)
        //    {
        //        if (p.Number == pizzaNo)
        //        {

        //            foundPizza=p;
        //        }


        //    }

        //    if (foundPizza!=null)
        //    {
        //        _pizzas.Remove(foundPizza);
        //    }
        //}

        //public void SearchPizza()
        //{
        //    SearchPizza();
        //    static void SetId(int number)
        //    {
        //        throw new NotImplementedException();
        //    }

        //    static int getId (string pizza)
        //    {
        //        throw new NotImplementedException();
        //    }
        //}
    }

}
    

