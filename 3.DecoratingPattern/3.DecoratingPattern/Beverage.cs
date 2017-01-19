using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.DecoratingPattern
{
    abstract class Beverage
    {
        public string description;

        public string Description
        {
            get { return description; }
        }

        public abstract double cost();
    }
}
