using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4._1FactoryMethodPattern
{
    class ChigagoPizzaStore : PizzaStore
    {
        public ChigagoPizzaStore()
        {
        }

        public override Pizza CreatePizza(Pza type)
        {
            switch (type)
            {
                case Pza.Cheese:
                    return new ChigagoCheesePizza();
                case Pza.Veggie:
                    return new ChigagoVeggiePizza();
                case Pza.Clam:
                    return new ChigagoClamPizza();
                case Pza.Pepperoni:
                    return new ChigagoPepperoniPizza();
                case Pza.Salami:
                    return new ChigagoSalamiPizza();
                case Pza.Tuna:
                    return new ChigagoTunaPizza();
                case Pza.Chicago:
                    return new ChigagoStylePizza();
                default:
                    return null;
            }
        }
    }
}
