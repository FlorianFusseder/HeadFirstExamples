using System;
using System.Windows.Input;

namespace ComplexRemote
{
    public class FanOnCommand : ICommand
    {

        private CeilingFan ceilingFan;

        public FanOnCommand(CeilingFan ceilingFan)
        {
            this.ceilingFan = ceilingFan;
        }

        public bool CanExecute()
        {
            return ceilingFan?.On == false;
        }

        public void Execute()
        {
            ceilingFan?.StartFan();
        }

        public void Undo()
        {
            ceilingFan?.StopFan();
        }
    }
}