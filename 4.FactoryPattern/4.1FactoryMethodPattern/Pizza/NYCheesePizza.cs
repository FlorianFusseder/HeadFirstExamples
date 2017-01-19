namespace _4._1FactoryMethodPattern
{
    internal class NYCheesePizza : Pizza
    {

        public NYCheesePizza()
        {
            name = "NY Style Sauce and CheesePizza";
            dough = "Thin Crust Dough";
            sauce = "Marianara Sauce";

            toppings.Add("Grated Reggiano Cheese");
        }
    }
}