using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategiePattern
{
    abstract class Duck
    {

        #region Attr
        protected FlyBehaviour flyBehaviour;

        public FlyBehaviour Flybehaviour
        {
            get { return flyBehaviour; }
            set { flyBehaviour = value; }
        }

        protected QuackBehaviour quackbehaviour;

        public QuackBehaviour Quackbehaviour
        {
            get { return quackbehaviour; }
            set { quackbehaviour = value; }
        }
        #endregion

        public Duck()
        {
        }

        public abstract void Display();

        public void Swim()
        {
            Console.WriteLine("Alle Enten Schwimmen");
        }

        public void PerformFly()
        {
            flyBehaviour.Fly();
        }

        public void PerformQuack()
        {
            quackbehaviour.MakeSound();
        }


    }
}
