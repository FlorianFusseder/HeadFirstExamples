using System;

namespace _4._2AbstractFActoryPattern
{
    public class ThinCrustDough : IDough
    {
        public string Name
        {
            get
            {
                return "Thin Crust Dough";
            }
        }
    }
}