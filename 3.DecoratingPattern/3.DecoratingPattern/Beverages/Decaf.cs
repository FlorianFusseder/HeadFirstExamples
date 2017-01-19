using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.DecoratingPattern.Beverages
{
    class Decaf : Beverage
    {
        public Decaf()
        {
            description = "Decaf";
        }

        public override double cost()
        {
            return 1.20;
        }
    }
}
