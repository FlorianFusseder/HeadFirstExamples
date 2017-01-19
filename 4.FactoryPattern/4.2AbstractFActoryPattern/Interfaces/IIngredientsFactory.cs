using System;

namespace _4._2AbstractFActoryPattern
{
    public interface IIngredientsFactory 
    {
        IDough createDough();
        ISauce createSauce();
        ICheese createCheese();
        IClam createClam();
        void cut();
        void bake();
        void box();
    }
}