using System;

namespace _4._2AbstractFActoryPattern
{
    public class CheesePizza : Pizza
    {
        public CheesePizza(IIngredientsFactory ingrFac) : base(ingrFac)
        {
            IngredientsFactory = ingrFac;
            Dough = ingrFac.createDough();
            Sauce = ingrFac.createSauce();
            Cheese = ingrFac.createCheese();
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
        }
    }
}