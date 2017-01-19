using System;
using System.Collections.Generic;

namespace _4._1FactoryMethodPattern
{
    public abstract class Pizza
    {
        protected string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        protected string dough;

        public string Dough
        {
            get { return dough; }
            set { dough = value; }
        }

        protected string sauce;

        public string Sauce
        {
            get { return sauce; }
            set { sauce = value; }
        }

        protected IList<string> toppings;

        public IList<string> Toppings
        {
            get { return toppings; }
            set { toppings = value; }
        }

        public Pizza()
        {
            toppings = new List<string>();
        }

        public virtual void prepare()
        {
            Console.WriteLine("Preparing: " + name);
            Console.WriteLine("Tossing " + dough + " dough...");
            Console.WriteLine("Put " + sauce + " sauce on...");
            Console.WriteLine("Adding Toppings:");

            foreach (var item in toppings)
            {
                Console.WriteLine("     Add " + item);
            }
        }
        public virtual void bake() => Console.WriteLine("Bei 350° für 25 minuten backen");
        public virtual void cut() => Console.WriteLine("Zu 1/8 stücken schneiden");
        public virtual void box() => Console.WriteLine("in offizelle box legen");
    }
}