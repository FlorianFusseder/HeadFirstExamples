using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8.TempalteMethodPattern
{
    abstract class TemplateMethod
    {

        
        public void prepareRecipte()
        {

            boilWater();
            brew();
            pourInCup();
            if(customerWantsCondiments())
                addCondiments();

        }

        public abstract void brew();

        public abstract void addCondiments();

        public void boilWater()
        {
            Console.WriteLine("Boiling Water");
        }

        public void pourInCup()
        {
            Console.WriteLine("Pouring into Cup");
        }

        //Hook -> kann überschreiben werden um ausführung zu beeinflussen
        public virtual bool customerWantsCondiments()
        {
            return true;
        }
    }
}
