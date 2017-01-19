using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4._1FactoryMethodPattern
{
    class NYPizzaStore : PizzaStore
    {
        public NYPizzaStore() 
        {
        }

        public override Pizza CreatePizza(Pza type)
        {
            switch (type)
            {
                case Pza.Cheese:
                    return new NYCheesePizza();
                case Pza.Veggie:
                    return new NYVeggiePizza();
                case Pza.Clam:
                    return new NYClamPizza();
                case Pza.Pepperoni:
                    return new NYPepperoniPizza();
                case Pza.Salami:
                    return new NYSalamiPizza();
                case Pza.Tuna:
                    return new NYTunaPizza();
                case Pza.NewYork:
                    return new NYStylePizza();
                default:
                    return null;
            }
        }
    }
}
