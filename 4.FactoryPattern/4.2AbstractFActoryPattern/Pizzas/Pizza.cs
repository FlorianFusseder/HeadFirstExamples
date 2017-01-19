using System;

namespace _4._2AbstractFActoryPattern
{
    public abstract class Pizza
    {
        protected IIngredientsFactory IngredientsFactory;

        protected string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        private IDough dough;

        public IDough Dough
        {
            get { return dough; }
            set { dough = value; }
        }

        private ISauce sauce;

        public ISauce Sauce
        {
            get { return sauce; }
            set { sauce = value; }
        }

        private ICheese cheese;

        public ICheese Cheese
        {
            get { return cheese; }
            set { cheese = value; }
        }

        private IClam clam;

        public IClam Clam
        {
            get { return clam; }
            set { clam = value; }
        }

        public Action cut;
        public Action bake;
        public Action box;

        public Pizza(IIngredientsFactory ingrFac)
        {

        }

        public abstract void prepare();
    }
}
