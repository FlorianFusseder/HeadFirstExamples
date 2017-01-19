using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4._2AbstractFActoryPattern
{
    class Program
    {
        static void Main(string[] args)
        {

            var nyStore = new NYPizzaStore();
            var chiStore = new ChicagoPizzaStore();

            nyStore.orderPizza(Pza.Cheese);
            chiStore.orderPizza(Pza.Cheese);
            nyStore.orderPizza(Pza.Clam);

            Console.ReadLine();
        }
    }
}
