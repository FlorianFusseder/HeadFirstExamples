using System;

namespace _4._2AbstractFActoryPattern
{
    public class ChicagoIngridientsFactory : IIngredientsFactory
    {
        public IDough createDough()
        {
            return new ThickCrustDough();
        }

        public ISauce createSauce()
        {
            return new PlumTomatoSauce();
        }

        public ICheese createCheese()
        {
            return new MozzarellaCheese();
        }

        public IClam createClam()
        {
            return new FrozenClam();
        }

        public void cut()
        {
            Console.WriteLine("In 1/8 schneiden");
        }

        public void bake()
        {
            Console.WriteLine("bei 250° für 25 Miuten backen");
        }

        public void box()
        {
            Console.WriteLine("In StandartBox verpacken");
        }
    }
}