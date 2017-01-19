using System;

namespace _4._0SimpleFactory
{
    public abstract class Pizza
    {
        protected string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public virtual void prepare()
        {
            Console.WriteLine("Prepare ingredients and dough");
        }
        public virtual void bake()
        {
            Console.WriteLine("Bake on 350° vor 250 minutes");
        }
        public virtual void cut()
        {
            Console.WriteLine("Cut in diagonal Slices");
        }
        public virtual void box()
        {
            Console.WriteLine("Put into PizzaBox");
        }

    }
}