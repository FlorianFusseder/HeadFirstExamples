using System;

namespace _4._2AbstractFActoryPattern
{
    public class ChicagoStylePizza : Pizza
    {
        public ChicagoStylePizza(IIngredientsFactory ingrFac) : base(ingrFac)
        {
        }

        public override void prepare()
        {
            throw new NotImplementedException();
        }
    }
}