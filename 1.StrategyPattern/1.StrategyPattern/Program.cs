using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategiePattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Duck d = new MallardDuck();

            d.PerformFly();
            d.PerformQuack();
            d.Display();

            d.Flybehaviour = new Fly.FlyRocket();
            d.Quackbehaviour = new Sounds.Skweak();
            Console.WriteLine("__________");


            d.PerformFly();
            d.PerformQuack();
            d.Display();

            Console.WriteLine("");

            Duck r = new RubberDuck();

            r.PerformFly();
            r.PerformQuack();
            r.Display();

            Console.ReadLine();
        }
    }
}
