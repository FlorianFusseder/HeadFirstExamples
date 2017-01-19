using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4._1FactoryMethodPattern
{
    class Program
    {
        static void Main(string[] args)
        {

            //atm nur nyCheese und Chicago Cheese vollständig definiert! bei bedarf mehrere Definieren...
            var nyStore = new NYPizzaStore();
            var CaliStore = new CaliforniaPizzaStore();
            var ChiStore = new ChigagoPizzaStore();


            var p1 = nyStore.orderPizza(Pza.Cheese);
            Console.WriteLine();
            var p2 = ChiStore.orderPizza(Pza.Cheese);


            

            Console.ReadLine();
        }
    }
}
