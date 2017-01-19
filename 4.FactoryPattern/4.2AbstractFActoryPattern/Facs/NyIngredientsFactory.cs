using System;

namespace _4._2AbstractFActoryPattern
{
    public class NyIngredientsFactory : IIngredientsFactory
    {
        public void bake()
        {
            Console.WriteLine("Bei 300° für 13 Minuten backen");
        }

        public void box()
        {
            Console.WriteLine("Orginal NEW YORK verpackung benutzen");
        }

        public void cut()
        {
            Console.WriteLine("In 1/4 Schneiden");
        }

        public ICheese createCheese()
        {
            return new ReggianoCheese();
        }

        public IDough createDough()
        {
            return new ThinCrustDough();
        }

        public ISauce createSauce()
        {
            return new MarinaraSauce();
        }

        public IClam createClam()
        {
            return new FreshClams();
        }

    }
}