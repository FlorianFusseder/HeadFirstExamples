using System;

namespace _4._0SimpleFactory
{
    internal class SimplePizzaFactory
    {
        public SimplePizzaFactory()
        {
        }

        internal Pizza createPizza(Pza pizza)
        {

            Pizza p = null;

            if (Pza.Cheese == pizza)
                p = new CheesePizza();
            else if (Pza.Pepperoni == pizza)
                p = new PepperoniPizza();
            else if (Pza.Clam == pizza)
                p = new ClamPizza();
            else if (Pza.Veggie == pizza)
                p = new VeggiePizza();

            return p;
        }
    }
}