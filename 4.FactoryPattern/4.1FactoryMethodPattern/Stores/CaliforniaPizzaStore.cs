using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4._1FactoryMethodPattern
{
    class CaliforniaPizzaStore : PizzaStore
    {
        public CaliforniaPizzaStore()
        {
        }

        public override Pizza CreatePizza(Pza type)
        {
            switch (type)
            {
                case Pza.Cheese:
                    return new CaliforniaCheesePizza();
                case Pza.Veggie:
                    return new CaliforniaVeggiePizza();
                case Pza.Clam:
                    return new CaliforniaClamPizza();
                case Pza.Pepperoni:
                    return new CaliforiniaPepperoniPizza();
                case Pza.Salami:
                    return new CaliforniaSalamiPizza();
                case Pza.Tuna:
                    return new CaliforniaTunaPizza();
                case Pza.California:
                    return new CaliforniaStylePizza();
                default:
                    return null;
            }

        }
    }
}
