using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.DecoratingPattern.Beverages
{
    class HouseBlend : Beverage
    {
        public HouseBlend()
        {
            description = "HouseBlend";
        }

        public override double cost()
        {
            return .80;
        }
    }
}
