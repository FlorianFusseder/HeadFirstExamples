using System;

namespace _4._2AbstractFActoryPattern
{
    public class ThickCrustDough : IDough
    {
        public string Name
        {
            get
            {
                return "Thick Crust Dough";
            }
        }
    }
}