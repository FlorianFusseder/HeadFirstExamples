using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4._2AbstractFActoryPattern
{
    public abstract class PizzaStore
    {

        public PizzaStore()
        {

        }

        public Pizza orderPizza(Pza type)
        {
            Pizza pizza = createPizza(type);

            pizza.prepare();
            pizza.bake();
            pizza.cut();
            pizza.box();
            Console.WriteLine();

            return pizza;
        }

        public abstract Pizza createPizza(Pza type);
    }
}
