using System;

namespace _4._2AbstractFActoryPattern
{
    public class NewYorkStylePizza : Pizza
    {
        public NewYorkStylePizza(IIngredientsFactory ingrFac) : base(ingrFac)
        {
        }

        public override void prepare()
        {
            throw new NotImplementedException();
        }
    }
}