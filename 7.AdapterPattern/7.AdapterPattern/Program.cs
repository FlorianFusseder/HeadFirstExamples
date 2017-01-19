using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7.AdapterPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var d = new MallardDuck();
            var t = new WildTurkey();
            var adaptedTurkey = new AdaptToDuck(t);
            var adaptedDuck = new AdaptToTurkey(d);

            d.fly();
            d.quack();

            t.fly();
            t.gobble();

            Console.WriteLine();

            testDuck(d);
            testDuck(adaptedTurkey);

            Console.WriteLine();

            testTurkey(t);
            testTurkey(adaptedDuck);
        }


        static void testDuck(Duck duck)
        {
            duck.quack();
            duck.fly();
        }

        static void testTurkey(Turkey turk)
        {
            turk.gobble();
            turk.fly();
        }
    }
}
