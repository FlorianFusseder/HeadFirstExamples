using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8.TempalteMethodPattern
{
    class Coffee: TemplateMethod
    {
        public override void brew()
        {
            Console.WriteLine("Dripping Coffee trough Filter");
        }

        public override void addCondiments()
        {
            Console.WriteLine("Adding Sugar and Milk");
        }

        public override bool customerWantsCondiments()
        {
            Console.WriteLine("Want condiments? (y/n)");
            string s = Console.ReadLine();

            return s.ToLower().StartsWith("y");
        }
    }
}
