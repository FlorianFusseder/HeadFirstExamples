using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8.TempalteMethodPattern
{
    class Tea: TemplateMethod
    {
        public override void brew()
        {
            Console.WriteLine("Steeping the tea");
        }

        public override void addCondiments()
        {
            Console.WriteLine("Adding Lemon");
        }
    }
}
