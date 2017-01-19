using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4._2AbstractFActoryPattern
{
    class NYPizzaStore : PizzaStore
    {

        private IIngredientsFactory nyIngredientsFactory;

        public NYPizzaStore()
        {
            nyIngredientsFactory = new NyIngredientsFactory();
        }


        public override Pizza createPizza(Pza type)
        {
            Pizza p = null;

            switch (type)
            {
                case Pza.Cheese:
                    p = new CheesePizza(nyIngredientsFactory);
                    p.Name = "NY CheesePizza";
                    break;
                case Pza.Clam:
                    p = new ClamPizza(nyIngredientsFactory);
                    p.Name = "NY ClamPizza";
                    break;
                case Pza.Pepperoni:
                    p = new PepperoniPizza(nyIngredientsFactory);
                    p.Name = "NY PepperoniPizza";
                    break;
                case Pza.NewYork:
                    p = new NewYorkStylePizza(nyIngredientsFactory);
                    p.Name = "NY StylePizza";
                    break;
                default:
                    return null;
            }

            return p;
        }
    }
}
