using System;

namespace _4._2AbstractFActoryPattern
{
    public class ClamPizza : Pizza
    {
        public ClamPizza(IIngredientsFactory ingrFac) : base(ingrFac)
        {
            IngredientsFactory = ingrFac;
            Dough = ingrFac.createDough();
            Sauce = ingrFac.createSauce();
            Cheese = ingrFac.createCheese();
            Clam = ingrFac.createClam();
            cut = ingrFac.cut;
            bake = ingrFac.bake;
            box = ingrFac.box;
        }

        public override void prepare()
        {
            Console.WriteLine("___________ Preparing " + name + " ___________");
            Console.WriteLine("Doug: " + Dough.Name);
            Console.WriteLine("Sauce: " + Sauce.Name);
            Console.WriteLine("Cheese: " + Cheese.Name);
            Console.WriteLine("Clams: " + Clam.Name);
        }
    }
}