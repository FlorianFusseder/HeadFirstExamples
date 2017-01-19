using System;

namespace _4._2AbstractFActoryPattern
{
    public class PepperoniPizza : Pizza
    {
        public PepperoniPizza(IIngredientsFactory ingrFac) : base(ingrFac)
        {
            
        }

        public override void prepare()
        {
            throw new NotImplementedException();
        }
    }
}