namespace _4._1FactoryMethodPattern
{
    internal class ChigagoCheesePizza : Pizza
    {
        public ChigagoCheesePizza()
        {
            name = "Chicago Style Deep dish Cheese Pizza";
            dough = "Extra Thick Crust Dough";
            sauce = "Plum Tomato Sauce";

            toppings.Add("Shredded Mozzarella Cheese");
        }

        public override void cut()
        {
            System.Console.WriteLine("Cutting the pizza into Square slices");
        }
    }
}