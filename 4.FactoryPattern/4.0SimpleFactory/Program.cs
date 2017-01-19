using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4._0SimpleFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            var store = new PizzaStore(new SimplePizzaFactory());

            var p = store.orderPizza(Pza.Cheese);

            Console.WriteLine(p.Name );
            Console.ReadLine();
        }
    }
}
