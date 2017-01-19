using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4._2AbstractFActoryPattern
{
    class ChicagoPizzaStore : PizzaStore
    {

        private IIngredientsFactory chicagoIngridientsFactory;

        public ChicagoPizzaStore()
        {
            chicagoIngridientsFactory = new ChicagoIngridientsFactory();
        }

        public override Pizza createPizza(Pza type)
        {
            Pizza p = null;

            switch (type)
            {
                case Pza.Cheese:
                    p = new CheesePizza(chicagoIngridientsFactory);
                    p.Name = "Chicago CheesePizza";
                    break;
                case Pza.Clam:
                    p = new ClamPizza(chicagoIngridientsFactory);
                    p.Name = "Chicago ClamPizza";
                    break;
                case Pza.Pepperoni:
                    p = new PepperoniPizza(chicagoIngridientsFactory);
                    p.Name = "Chicago PepperoniPizza";
                    break;
                case Pza.Chicago:
                    p = new ChicagoStylePizza(chicagoIngridientsFactory);
                    p.Name = "Chicago StylePizza";
                    break;
                default:
                    return null;
            }

            return p;
        }
    }
}
