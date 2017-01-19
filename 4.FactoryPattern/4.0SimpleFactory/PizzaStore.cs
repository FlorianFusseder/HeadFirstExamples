using System;

namespace _4._0SimpleFactory
{
    internal class PizzaStore
    {
        private SimplePizzaFactory simplePizaFactory;

        public PizzaStore(SimplePizzaFactory simplePizaFactory)
        {
            this.simplePizaFactory = simplePizaFactory;
        }

        public Pizza orderPizza(Pza pizza)
        {
            Pizza p;
            p = simplePizaFactory.createPizza(pizza);

            p.prepare();
            p.bake();
            p.cut();
            p.box();

            return p;            
        }
    }
}