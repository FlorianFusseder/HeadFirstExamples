using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComplexRemote
{
    public abstract class FanStufe : ICommand
    {
        protected CeilingFan Fan;
        protected FanSpeed stufe;
        protected FanSpeed prevStufe;

        public FanStufe(CeilingFan Fan)
        {
            this.Fan = Fan;
        }

        public bool CanExecute()
        {
            return Fan.On;
        }

        public void Undo()
        {
            Fan.Stufe = prevStufe;
        }

        public void Execute()
        {
            prevStufe = Fan.Stufe;
            SetSpeed();
            Console.WriteLine($"Set Speed to {Fan.Stufe}");
        }

        abstract protected void SetSpeed();
    }
}
