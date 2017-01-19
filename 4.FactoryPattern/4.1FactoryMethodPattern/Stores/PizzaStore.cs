using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4._1FactoryMethodPattern
{
    abstract class PizzaStore
    {
        public PizzaStore()
        {

        }

        public Pizza orderPizza(Pza s)
        {
            Pizza pizza = CreatePizza(s);

            if (pizza != null)
            {
                pizza.prepare();
                pizza.bake();
                pizza.cut();
                pizza.box();
            }

            return pizza;
        }

        public abstract Pizza CreatePizza(Pza s);
    }
}
