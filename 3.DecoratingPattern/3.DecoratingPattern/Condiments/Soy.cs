using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.DecoratingPattern.Condiments
{
    class Soy: CondimentCreator
    {
        private Beverage beverage;

        public Soy(Beverage beverage)
        {
            this.beverage = beverage;
            this.description = this.beverage.Description + " + Soy";
        }

        public override double cost()
        {
            return .20 + beverage.cost();
        }
    }
}
