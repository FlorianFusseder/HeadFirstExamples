using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace _3.DecoratingPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Beverage b1 = new Beverages.Espresso();

            Console.WriteLine(b1.Description + " -> " + b1.cost());

            Beverage b2 = new Beverages.Decaf();
            b2 = new Condiments.Mocha(b2);

            Console.WriteLine(b2.Description + " -> " + b2.cost());

            Beverage b3 = new Beverages.DarkRoast();

            b3 = new Condiments.Soy(b3);
            b3 = new Condiments.Whip(b3);
            b3 = new Condiments.Mocha(b3);

            Console.WriteLine(b3.Description + " -> " + b3.cost());

            Console.ReadLine();
        }
    }
}
